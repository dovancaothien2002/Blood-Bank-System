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
    public class CityController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {
            int limit = 4;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/cities");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/cities/searchC/" + name);
            }
            var city = JsonConvert.DeserializeObject<List<CityModel>>(data);
            IPagedList<CityModel> cityNew = await city.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(cityNew);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(City city)
        {
            if (!ModelState.IsValid)
            {
                return View(city);
            }

            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/cities/search/" + city.cityName);
            List<CityModel> list = JsonConvert.DeserializeObject<List<CityModel>>(json);
            if (list.Count == 1)
            {
                TempData["err"] = "This city name " + city.cityName + " already exists";
                return View("Create");

            }
            else
            {
                city.create_at = DateTime.Now;
                city.update_at = DateTime.Now;
                var result = await client.PostAsJsonAsync<City>("api/cities", city);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/cities/" + id);
            CityModel city = JsonConvert.DeserializeObject<CityModel>(result);
            return View(city);
        }
        public async Task<IActionResult> Edit(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/cities/" + id);
            CityModel cityModel = JsonConvert.DeserializeObject<CityModel>(result);
            City city = new City
            {
                cityId = cityModel.cityId,
                cityName = cityModel.cityName,
                create_at = cityModel.create_at,
                update_at = cityModel.update_at,
            };
            return View(city);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(City city)
        {
            if (!ModelState.IsValid)
            {
                return View(city);
            }
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/cities/searchEdit/" + city.cityName + "&" + city.cityId);
            List<CityModel> list = JsonConvert.DeserializeObject<List<CityModel>>(json);

            if (list.Count == 1)
            {
                TempData["err"] = "This city name " + city.cityName + " already exists";
                return View("Edit");
            }
             else
            {
                city.create_at = city.create_at;
                city.update_at = DateTime.Now;
                await client.PutAsJsonAsync<City>("api/cities/" + city.cityId, city);
                return RedirectToAction("Index");
            }
        }
           
        public async Task<IActionResult> Delete(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.DeleteAsync("api/cities/" + id);
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