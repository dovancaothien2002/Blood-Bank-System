using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Client.Models;
using X.PagedList;

namespace Client.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BloodBankController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {
            int limit = 8;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/bloodbanks");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/bloodbanks/searchByNameC/" + name);
            }
            var bb = JsonConvert.DeserializeObject<List<BloodBankModel>>(data);
            if (bb.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<BloodBankModel> bbNew = await bb.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(bbNew);
        }

        public async Task<IActionResult> Create()
        {
            client.BaseAddress = new Uri(host_api);

            var result = await client.GetStringAsync("api/districts");
            List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(result);
            ViewBag.district = new SelectList(district, "districtId", "districtName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BloodBank bloodBank)
        {
            client.BaseAddress = new Uri(host_api);
            if (!ModelState.IsValid)
            {

                var result = await client.GetStringAsync("api/districts");
                List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(result);
                ViewBag.district = new SelectList(district, "districtId", "districtName");
                return View(bloodBank);
            }

            var json = await client.GetStringAsync("api/bloodbanks/searchByName/" + bloodBank.bbName);
            List<BloodBank> list = JsonConvert.DeserializeObject<List<BloodBank>>(json);
            if (list.Count == 1)
            {

                var result = await client.GetStringAsync("api/districts");
                List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(result);
                ViewBag.district = new SelectList(district, "districtId", "districtName");
                TempData["err"] = "This Blood Bank name " + bloodBank.bbName + " already exists";
                return View("Create");

            }
            else
            {
                bloodBank.create_at = DateTime.Now;
                bloodBank.update_at = DateTime.Now;
                var result = await client.PostAsJsonAsync<BloodBank>("api/bloodbanks", bloodBank);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/bloodbanks/" + id);
            BloodBankModel city = JsonConvert.DeserializeObject<BloodBankModel>(result);
            return View(city);
        }
        public async Task<IActionResult> Edit(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/districts");
            List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(data);
            ViewBag.district = new SelectList(district, "districtId", "districtName");

            var result = await client.GetStringAsync("api/bloodbanks/" + id);
            BloodBankModel bb = JsonConvert.DeserializeObject<BloodBankModel>(result);
            BloodBank b = new BloodBank
            {
                bbId = bb.bbId,
                bbName = bb.bbName,
                address = bb.address,
                calendar = bb.calendar,
                email = bb.email,
                password=bb.password,
                hotline = bb.hotline,
                districtId = bb.districtId,
                create_at = bb.create_at,
                update_at = bb.update_at,
            };
            return View(b);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BloodBank b)
        {
            client.BaseAddress = new Uri(host_api);

            if (!ModelState.IsValid)
            {
                var data = await client.GetStringAsync("api/districts");
                List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(data);
                ViewBag.district = new SelectList(district, "districtId", "districtName");
                return View(b);
            }
            var json = await client.GetStringAsync("api/bloodbanks/searchByNameEdit/" + b.bbName + "&" + b.bbId);
            List<BloodBankModel> list = JsonConvert.DeserializeObject<List<BloodBankModel>>(json);
            if (list.Count == 1)
            {

                var result = await client.GetStringAsync("api/districts");
                List<DistrictModel> district = JsonConvert.DeserializeObject<List<DistrictModel>>(result);
                ViewBag.district = new SelectList(district, "districtId", "districtName");
                TempData["err"] = "This Blood Bank name " + b.bbName + " already exists";
                return View("Edit");

            }
            else
            {
                b.update_at = DateTime.Now;
                await client.PutAsJsonAsync<BloodBank>("api/bloodbanks/" + b.bbId, b);
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.DeleteAsync("api/bloodbanks/" + id);
            if (result.IsSuccessStatusCode)
            {
                TempData["Ok"] = "Delete Successful";
            }
            else
            {
                TempData["Error"] = "Can't Delete";
            }
            return RedirectToAction("Index");
        }
    }
}