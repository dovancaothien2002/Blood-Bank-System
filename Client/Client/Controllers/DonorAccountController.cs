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
    public class DonorAccountController : Controller
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(json);
            ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");

            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
              
                var donorAccount = JsonConvert.DeserializeObject<DonorModel>(session);
                 data_json = await client.GetStringAsync("api/districts/" + donorAccount.districtId );
                DistrictModel district = JsonConvert.DeserializeObject<DistrictModel>(data_json);

                data_json = await client.GetStringAsync("api/districts/search/" + district.cityId);
                List<DistrictModel> listdistrict = JsonConvert.DeserializeObject<List<DistrictModel>>(data_json);
                ViewBag.districts = new SelectList(listdistrict, "districtId", "districtName");

                ViewBag.cityDefault = district.cityId;
                Donor donor = new Donor
                {
                    donorId = donorAccount.donorId,
                    donorName = donorAccount.donorName,
                    address = donorAccount.address,
                    email = donorAccount.email,
                    phone = donorAccount.phone,
                    status = donorAccount.status,
                    gender = donorAccount.gender,
                    bloodId = donorAccount.bloodId,
                    districtId = donorAccount.districtId,
                    create_at = donorAccount.create_at,
                    update_at = donorAccount.update_at,
                    birthday = donorAccount.birthday,
                    age = donorAccount.age,
                    weight = donorAccount.weight,
                    password = donorAccount.password
                };
                return View(donor);
            }
            else
            {
                return RedirectToAction();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("donorId,donorName,weight,address,age,password,birthday,email,phone,gender,districtId")] Donor donor)
        {
            var session = HttpContext.Session.GetString("Donor");
            var donorAccount = JsonConvert.DeserializeObject<DonorModel>(session);

            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/bloods");
            List<BloodModel> listblood = JsonConvert.DeserializeObject<List<BloodModel>>(json);
            var data_json = await client.GetStringAsync("api/cities");
            List<CityModel> listcity = JsonConvert.DeserializeObject<List<CityModel>>(data_json);
            ViewBag.cities = new SelectList(listcity, "cityId", "cityName");

            data_json = await client.GetStringAsync("api/districts/" + donor.districtId);
            DistrictModel district = JsonConvert.DeserializeObject<DistrictModel>(data_json);
            data_json = await client.GetStringAsync("api/districts/search/" + district.cityId);
            List<DistrictModel> listdistrict = JsonConvert.DeserializeObject<List<DistrictModel>>(data_json);
            ViewBag.districts = new SelectList(listdistrict, "districtId", "districtName");

            ViewBag.cityDefault = district.cityId;

            if (ModelState.IsValid)
            {
                donor.weight = donorAccount.weight;
                donor.create_at = donorAccount.create_at;
                donor.status = donorAccount.status;
                donor.update_at = DateTime.Now;
                donor.bloodId = donorAccount.bloodId;
                //Check Unique Email//
                var checkEmail = await checkUniqueEmail(donor.donorId, donor.email);
                //Check Unique Email//
                if(checkEmail == true)
                {
                    ViewBag.checkEmail = "This email is already registered by another account";
                }
                else
                {
                    var result = await client.PutAsJsonAsync("api/Donors/" + donor.donorId, donor);
                     data_json = await client.GetStringAsync("api/Donors/" + donor.donorId);
                 
                    HttpContext.Session.SetString("Donor", data_json);
                    ViewBag.Ok = "Your profile profile updated successfully !";
                }

                ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
                return View("Index");
            }
            else
            {
                ViewBag.bloods = new SelectList(listblood, "bloodId", "bloodName");
                return View("Index");
            }
           
        }

      

        public async Task<IActionResult> MyRequest()
        {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                var data_json = await client.GetStringAsync("api/RequestToDonors/searchbydonor/" + donor.donorId + "&" + 0);
                List<RequestToDonorModel> listRq = JsonConvert.DeserializeObject<List<RequestToDonorModel>>(data_json);
               
                return View(listRq);
            }
            else
            {
                return RedirectToAction();
            }
        }

        public async Task<IActionResult> MobiLink()
        {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                var data_json = await client.GetStringAsync("api/MobiLinkRequests/listshowed");
                List<MobiLinkRequestModel> listRq = JsonConvert.DeserializeObject<List<MobiLinkRequestModel>>(data_json);

                return View(listRq);
            }
            else
            {
                return RedirectToAction();
            }
        }

        public async Task<IActionResult> MobiLinkdetail(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/MobiLinkRequests/" + id);
            MobiLinkRequestModel rqModel = JsonConvert.DeserializeObject<MobiLinkRequestModel>(result);
            return View(rqModel);
        }

        public async Task<IActionResult> RequestDetail(int Id)
            {
                client.BaseAddress = new Uri(host_api);
                var id = Id;
                var data_json = await client.GetStringAsync("api/RequestToDonors/" + id);
                RequestToDonorModel rqModel = JsonConvert.DeserializeObject<RequestToDonorModel>(data_json);

                return View(rqModel);
            }

            public async Task<IActionResult> RequestHistory()
            {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                var data_json = await client.GetStringAsync("api/RequestToDonors/searchbydonor/" + donor.donorId + "&" + 1);
                List<RequestToDonorModel> listRq = JsonConvert.DeserializeObject<List<RequestToDonorModel>>(data_json);

                return View(listRq);
            }
            else
            {
                return RedirectToAction();
            }
        }

        public async Task<IActionResult> MyDonation()
        {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                var data_json = await client.GetStringAsync("api/DonationRequests/searchbydonor/" + donor.donorId);
                List<DonationRequestModel> listRq = JsonConvert.DeserializeObject<List<DonationRequestModel>>(data_json);

                return View(listRq);
            }
            else
            {
                return RedirectToAction();
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
            if(dModel != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Confirm (int rqId,int type)
        {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("Donor");
            if (session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);

                var json = await client.GetStringAsync("api/RequestToDonors/Confirm/" + rqId + "&"+type);
                List<RequestToDonorModel> listRq = JsonConvert.DeserializeObject<List<RequestToDonorModel>>(json);

                return View("MyRequest",listRq);
            }
            else
            {
                return RedirectToAction();
            }
        }


    }
}