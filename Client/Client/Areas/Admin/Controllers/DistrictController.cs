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

    public class DistrictController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {
            int limit = 4;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/districts");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/districts/searchC/" + name);
            }
            var d = JsonConvert.DeserializeObject<List<DistrictModel>>(data);
            if (d.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<DistrictModel> dNew = await d.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(dNew);
        }

        public async Task<IActionResult> Create()
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/cities");
            List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(result);
            ViewBag.city = new SelectList(city, "cityId", "cityName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(District district)
        {
            client.BaseAddress = new Uri(host_api);
            if (!ModelState.IsValid)
            {
                var result = await client.GetStringAsync("api/cities");
                List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(result);
                ViewBag.city = new SelectList(city, "cityId", "cityName");
                return View(district);
            }

            var json = await client.GetStringAsync("api/districts/searchByName/" + district.districtName);
            List<DistrictModel> list = JsonConvert.DeserializeObject<List<DistrictModel>>(json);
            if (list.Count == 1)
            {
                var result = await client.GetStringAsync("api/cities");
                List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(result);
                ViewBag.city = new SelectList(city, "cityId", "cityName");
                TempData["err"] = "This district name " + district.districtName + " already exists";
                return View("Create");

            }
            else
            {
                district.create_at = DateTime.Now;
                district.update_at = DateTime.Now;
                var result = await client.PostAsJsonAsync<District>("api/districts", district);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/districts/" + id);
            DistrictModel city = JsonConvert.DeserializeObject<DistrictModel>(result);
            return View(city);
        }
        public async Task<IActionResult> Edit(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/cities");
            List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(data);
            ViewBag.city = new SelectList(city, "cityId", "cityName");
            var result = await client.GetStringAsync("api/districts/" + id);
            DistrictModel distristModel = JsonConvert.DeserializeObject<DistrictModel>(result);
            District d = new District
            {
                districtId = distristModel.districtId,
                districtName = distristModel.districtName,
                create_at = distristModel.create_at,
                update_at = distristModel.update_at,
                cityId = distristModel.cityId,
            };
            return View(d);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(District d)
        {
            client.BaseAddress = new Uri(host_api);

            if (!ModelState.IsValid)
            {
                //return View(d);
                var result = await client.GetStringAsync("api/cities");
                List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(result);
                ViewBag.city = new SelectList(city, "cityId", "cityName");
                return View(d);
            }
            var json = await client.GetStringAsync("api/districts/searchEdit/" + d.districtName + "&" + d.districtId);
            List<DistrictModel> list = JsonConvert.DeserializeObject<List<DistrictModel>>(json);
            if (list.Count == 1)
            {
                var result = await client.GetStringAsync("api/cities");
                List<CityModel> city = JsonConvert.DeserializeObject<List<CityModel>>(result);
                ViewBag.city = new SelectList(city, "cityId", "cityName");
                TempData["err"] = "This district name " + d.districtName + " already exists";
                return View("Edit");
            }
            else
            {
                d.create_at = d.create_at;
                d.update_at = DateTime.Now;
                await client.PutAsJsonAsync<District>("api/districts/" + d.districtId, d);
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.DeleteAsync("api/districts/" + id);
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