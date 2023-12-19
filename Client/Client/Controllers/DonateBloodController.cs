using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class DonateBloodController : Controller
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DonateToBloodBank()
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

        [HttpGet]
        [Route("FormDonateToBloodBank/{bbId}")]
        public async Task<IActionResult> FormDonateToBloodBank(int bbId)
        {
            client.BaseAddress = new Uri(host_api);
            var data_json = await client.GetStringAsync("api/BloodBanks/" + bbId);
            BloodBankModel bbModel = JsonConvert.DeserializeObject<BloodBankModel>(data_json);
            ViewBag.bbName = bbModel.bbName;
            ViewBag.bbId = bbModel.bbId;
            ViewBag.bbAddress = bbModel.address;
            ViewBag.bbHotline = bbModel.hotline;
            ViewBag.bbEmail = bbModel.email;

            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                ViewBag.donorId = donor.donorId;
                ViewBag.donorName = donor.donorName;

                ViewBag.donorAge = donor.age;
                ViewBag.donorBlood = donor.bloodName;
                ViewBag.donorAddress = donor.address;
                ViewBag.donorPhone = donor.phone;
                ViewBag.donorEmail = donor.email;
                return View();
            }
            else
            {
                return View("DonateToBloodBank");
            }  
        }

        [HttpPost]
        public async Task<IActionResult> SendAppointmentToBloodBank(DonationRequest dr)
        {
            client.BaseAddress = new Uri(host_api);
            if (ModelState.IsValid)
            {

                
                dr.create_at = DateTime.Now;
                dr.update_at = DateTime.Now;
                dr.status = 0;
               
                
                var data_json = await client.PostAsJsonAsync("api/DonationRequests", dr);
                var statusCode = data_json.IsSuccessStatusCode;
                ViewBag.Ok = "Your request has been sent. Please check your phone message and Email when we get back to you as soon as possible.";
                return View("Success");
            }
            else
            {
                var data_json = await client.GetStringAsync("api/BloodBanks/" + dr.bbId);
                BloodBankModel bbModel = JsonConvert.DeserializeObject<BloodBankModel>(data_json);
                ViewBag.bbName = bbModel.bbName;
                ViewBag.bbId = bbModel.bbId;
                ViewBag.bbAddress = bbModel.address;
                ViewBag.bbHotline = bbModel.hotline;
                ViewBag.bbEmail = bbModel.email;

                var session = HttpContext.Session.GetString("Donor");
                if (session != null)
                {
                    var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                    ViewBag.donorId = donor.donorId;
                    ViewBag.donorName = donor.donorName;

                    ViewBag.donorAge = donor.age;
                    ViewBag.donorBlood = donor.bloodName;
                    ViewBag.donorAddress = donor.address;
                    ViewBag.donorPhone = donor.phone;
                    ViewBag.donorEmail = donor.email;
                    
                }
                return View("FormDonateToBloodBank");
            }
        }

        [HttpPost]
        public async Task<JsonResult> searchBloodBank(string districtId)
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/BloodBanks/searchbb/" + districtId);
            List<BloodBankModel> list = JsonConvert.DeserializeObject<List<BloodBankModel>>(json);
            return Json(list);
        }

        [HttpPost]
        public async Task<IActionResult> checkApointmentToBloodBank(int bloodBankId, int dId)
        {

            client.BaseAddress = new Uri(host_api);
            var data = new
            {
                bbId = bloodBankId,
                donorId = dId
               
            };

            var response = await client.PostAsJsonAsync("api/DonationRequests/checkAppointment/", data);
            var result = response.Content.ReadAsStringAsync().Result;
            DonationRequestModel rq = JsonConvert.DeserializeObject<DonationRequestModel>(result);
            return Json(rq);
        }


        public async Task<IActionResult> Register()
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");
            ViewBag.cityDefault = 0;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("donorName,address,weight,age,password,birthday,email,phone,gender,districtId,bloodId")] Donor donor)
        {
            ViewBag.cityDefault = 0;
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(json);
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");

            if(donor.districtId != 0)
            {
                data_json = await client.GetStringAsync("api/districts/" + donor.districtId);
                DistrictModel district = JsonConvert.DeserializeObject<DistrictModel>(data_json);
                data_json = await client.GetStringAsync("api/districts/search/" + district.cityId);
                List<DistrictModel> listdistrict = JsonConvert.DeserializeObject<List<DistrictModel>>(data_json);
                ViewBag.districts = new SelectList(listdistrict, "districtId", "districtName");

                ViewBag.cityDefault = district.cityId;
            }

            if (ModelState.IsValid)
            {
              
                donor.create_at = DateTime.Now;
                donor.status = true;
                donor.update_at = DateTime.Now;

                //Check Unique Email//
                var checkEmail = await checkUniqueEmail(donor.donorId, donor.email);
                //Check Unique Email//
                if (checkEmail == true)
                {
                    ViewBag.checkEmail = "This email is already registered by another account";
                    ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
                    return View("Register");
                }
                else
                {
                    var result = await client.PostAsJsonAsync("api/Donors", donor);
                   
                    ViewBag.Ok = "Successfully signing up for an account !";
                    return View("Success");
                }

            }
            else
            {
                ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
                return View("Register");
            }

        }

        [HttpPost]
        public async Task<bool> checkUniqueEmail(int dId, string dEmail)
        {

            var data = new
            {
                donorId = dId,
                donorEmail = dEmail
            };

            var response = await client.PostAsJsonAsync("api/Donors/checkUniqueEmail/", data);
            var result = response.Content.ReadAsStringAsync().Result;
            DonorModel dModel = JsonConvert.DeserializeObject<DonorModel>(result);
            if (dModel != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}