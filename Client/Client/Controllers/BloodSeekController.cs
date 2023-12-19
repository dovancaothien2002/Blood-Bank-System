using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Client.Models;

namespace Client.Controllers
{
    public class BloodSeekController : Controller
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");
            data_json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            return View();
        }

        // TIM KIEM GUI YEU CAU TIM MAU DEN BLOOD BANK

        public async Task<IActionResult> RequestToBloodBank()
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");
            data_json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> searchBloodBank(string districtId, string bloodId)
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/BloodBanks/searchbs/" + districtId + "&" + bloodId);
            List<BloodStockModelB> list = JsonConvert.DeserializeObject<List<BloodStockModelB>>(json);
            return Json(list);
        }

        [HttpPost]
        public async Task<IActionResult> SendRequestToBloodBank([Bind("fullname,address,gender,birthday,expected_date,email,phone,amount,note,hospitaltreatment,bbId,bloodId")] RequestToBloodBank rq)
        {
            if (ModelState.IsValid)
            {

                client.BaseAddress = new Uri(host_api);
                rq.create_at = DateTime.Now;
                rq.update_at = DateTime.Now;
                rq.status = 0;
                var data_json = await client.PostAsJsonAsync("api/RequestToBloodBanks", rq);
                ViewBag.Ok = "Your request has been sent. Please check your phone message and Email when we get back to you as soon as possible.";
                return View("Success");
            }
          
           
            return View("FormRqToBloodBank");
        }

        [HttpGet]
        [Route("FormRqToBloodBank/{bbId}&{bloodId}")]
        public async Task<IActionResult> FormRqToBloodBank(int bbId, int bloodId)
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/BloodBanks/" + bbId);
            BloodBankModel bbModel = JsonConvert.DeserializeObject<BloodBankModel>(data_json);
            ViewBag.bbName = bbModel.bbName;
            ViewBag.bbId = bbModel.bbId;

            data_json = await client.GetStringAsync("api/Bloods/" + bloodId);
            BloodModel bModel = JsonConvert.DeserializeObject<BloodModel>(data_json);
            ViewBag.bloodId = bModel.bloodId;
            ViewBag.bloodName = bModel.bloodName;

            return View("FormRqToBloodBank");
        }

        // TIM KIEM GUI YEU CAU TIM MAU DEN BLOOD BANK


        // TIM KIEM GUI YEU CAU TIM MAU DEN DONOR

        public async Task<IActionResult> RequestToDonor()
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");
            data_json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> searchDonor(int districtId, string bloodId)
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/Donors/search/" + districtId + "&" + bloodId);
            List<DonorModel> list = JsonConvert.DeserializeObject<List<DonorModel>>(json);
            return Json(list);
        }

        [HttpGet]
        [Route("FormRqToDonor/{donorId}&{bloodId}")]
        public async Task<IActionResult> FormRqToDonor(int donorId, int bloodId)
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/Donors/" + donorId);
            DonorModel donorModel = JsonConvert.DeserializeObject<DonorModel>(data_json);
            ViewBag.donorName = donorModel.donorName;
            ViewBag.donorId = donorModel.donorId;

            data_json = await client.GetStringAsync("api/Bloods/" + bloodId);
            BloodModel bModel = JsonConvert.DeserializeObject<BloodModel>(data_json);
            ViewBag.bloodId = bModel.bloodId;
            ViewBag.bloodName = bModel.bloodName;

            return View("FormRqToDonor");
        }

        [HttpPost]
        public async Task<IActionResult> SendRequestToDonor([Bind("fullname,address,gender,birthday,expected_date,email,phone,amount,note,hospitaltreatment,donorId")] RequestToDonor rq)
        {
            if (ModelState.IsValid)
            {

                client.BaseAddress = new Uri(host_api);
                rq.create_at = DateTime.Now;
                rq.update_at = DateTime.Now;
                rq.status = 0;
                var data_json = await client.PostAsJsonAsync("api/RequestToDonors", rq);
                ViewBag.Ok = "Your request has been sent. Please check your phone message and Email when we get back to you as soon as possible.";
                return View("Success");
            }


            return View("FormRqToDonor");
        }


        // TIM KIEM GUI YEU CAU TIM MAU DEN DONOR

        [HttpPost]
        public async Task<JsonResult> SearchDistrict(string key)
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/districts/search/" + key);
            List<DistrictModel> list = JsonConvert.DeserializeObject<List<DistrictModel>>(json);
            return Json(list);
        }

       

        [HttpPost]
        public async Task<JsonResult> checkBloodStock(string bbId, string bloodId)
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/BloodStocks/checkBloodStock/" + bbId +"&"+bloodId);
            BloodStockModel bs = JsonConvert.DeserializeObject<BloodStockModel>(json);
           
            return Json(bs);
        }

        [HttpPost]
        public async Task<IActionResult> checkRequestToBloodBankEmail(int bloodBankId, string donorEmail)
        {
           
            client.BaseAddress = new Uri(host_api);
            var data = new
            {
                bbId = bloodBankId,
                rqEmail = donorEmail
            };

            var response = await client.PostAsJsonAsync("api/RequestToBloodBanks/checkRequest/", data );
            var result = response.Content.ReadAsStringAsync().Result;
            RequestToBloodBank rq = JsonConvert.DeserializeObject<RequestToBloodBank>(result);
            return Json(rq);
        }

        [HttpPost]
        public async Task<IActionResult> checkRequestToDonorEmail(int dId, string donorEmail)
        {
           
            client.BaseAddress = new Uri(host_api);
            var data = new
            {
                donorId = dId,
                rqEmail = donorEmail
            };

            var response = await client.PostAsJsonAsync("api/RequestToDonors/checkRequest/", data);
            var result = response.Content.ReadAsStringAsync().Result;
            RequestToDonorModel rq = JsonConvert.DeserializeObject<RequestToDonorModel>(result);
            return Json(rq);
        }

    }
}