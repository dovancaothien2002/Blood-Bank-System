using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BloodController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {

            int limit = 4;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/bloods");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/bloods/search/" + name);
            }
            var b = JsonConvert.DeserializeObject<List<BloodModel>>(data);
            if (b.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<BloodModel> bbNew = await b.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(bbNew);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blood b)
        {
            if (!ModelState.IsValid)
            {
                return View(b);
            }

            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods/search/" + b.bloodName);
            List<BloodModel> list = JsonConvert.DeserializeObject<List<BloodModel>>(json);
            if (list.Count == 1)
            {
                TempData["err"] = "This blood name " + b.bloodName + " already exists";
                return View("Create");

            }
            else
            {
                b.create_at = DateTime.Now;
                b.update_at = DateTime.Now;
                var result = await client.PostAsJsonAsync<Blood>("api/bloods", b);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/bloods/" + id);
           BloodModel b = JsonConvert.DeserializeObject<BloodModel>(result);
            return View(b);
        }
        public async Task<IActionResult> Edit(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/bloods/" + id);
            BloodModel b  = JsonConvert.DeserializeObject<BloodModel>(result);
            Blood blood  = new Blood
            {
                bloodId = b.bloodId,
                bloodName = b.bloodName,
                create_at = b.create_at,
                update_at = b.update_at,
            };
            return View(blood);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Blood blood)
        {
            if (!ModelState.IsValid)
            {
                return View(blood);
            }
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods/searchEdit/" + blood.bloodName + "&" + blood.bloodId);
            List<BloodModel> list = JsonConvert.DeserializeObject<List<BloodModel>>(json);

            if (list.Count == 1)
            {
                TempData["err"] = "This blood name " + blood.bloodName + " already exists";
                return View("Edit");
            }
            else
            {
                blood.create_at = blood.create_at;
                blood.update_at = DateTime.Now;
                await client.PutAsJsonAsync<Blood>("api/bloods/" + blood.bloodId, blood);
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            client.BaseAddress = new Uri(host_api);
          
             var result = await client.DeleteAsync("api/bloods/" + id);
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