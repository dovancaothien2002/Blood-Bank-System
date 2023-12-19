using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using X.PagedList;

namespace Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MobiLinkController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {

            int limit = 4;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/MobiLinkRequests");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/MobiLinkRequests/search/" + name + "&" + 0);
            }
            var rq = JsonConvert.DeserializeObject<List<MobiLinkRequestModel>>(data);
            if (rq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<MobiLinkRequestModel> list = await rq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MobiLinkRequest m)
        {
            if (!ModelState.IsValid)
            {
                return View(m);
            }
            else
            {
                client.BaseAddress = new Uri(host_api);
                /// var json = await client.GetStringAsync("api/bloods/search/" + b.bloodName);
                /// List<BloodModel> list = JsonConvert.DeserializeObject<List<BloodModel>>(json);
                //  if (list.Count == 1)
                // {
                //      TempData["err"] = "This blood name " + b.bloodName + " already exists";
                //      return View("Create");

                //   }
                //else
                //{
                m.create_at = DateTime.Now;
                m.update_at = DateTime.Now;
                var result = await client.PostAsJsonAsync<MobiLinkRequest>("api/MobiLinkRequests", m);

                return RedirectToAction("Index");
            }

        }

        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/MobiLinkRequests/" + id);
            MobiLinkRequestModel rqModel = JsonConvert.DeserializeObject<MobiLinkRequestModel>(result);
            return View(rqModel);
        }
        public async Task<IActionResult> Edit(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");

            var result = await client.GetStringAsync("api/MobiLinkRequests/" + id);
            MobiLinkRequestModel rq = JsonConvert.DeserializeObject<MobiLinkRequestModel>(result);
            MobiLinkRequest rqModel = new MobiLinkRequest
            {
                mlrId = rq.mlrId,
                fullname = rq.fullname,
                address = rq.address,
                bloodId = rq.bloodId,
                
                email = rq.email,
                expected_date = rq.expected_date,
                create_at = rq.create_at,
                hospitaltreatment = rq.hospitaltreatment,
                note = rq.note,
                phone = rq.phone,
                status = rq.status,
                update_at = rq.update_at

            };
            return View(rqModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MobiLinkRequest d)
        {
            client.BaseAddress = new Uri(host_api);

            if (!ModelState.IsValid)
            {
                //return View(d);
                var data_json = await client.GetStringAsync("api/bloods");
                List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
                ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
                return View(d);
            }
            else
            {
              
                d.update_at = DateTime.Now;
                await client.PutAsJsonAsync("api/MobiLinkRequests/" + d.mlrId, d);
                return RedirectToAction("Index");
               
            }
           
        }
        public async Task<IActionResult> Delete(int id)
        {

            client.BaseAddress = new Uri(host_api);
            var result = await client.DeleteAsync("api/MobiLinkRequests/" + id);
            if (result.IsSuccessStatusCode)
            {
                TempData["Ok"] = "Delete Successful";
            }
            else
            {
                TempData["Error"] = "Can't Delete";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}