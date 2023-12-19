using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;


namespace Client.Controllers
{
    public class LoginController : Controller
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Login login,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                ViewBag.error = "";
                ViewBag.status = "";


                client.BaseAddress = new Uri(host_api);
                DonorModel donorcheck = new DonorModel
                {
                    email = login.email,
                    password = login.password
                };

                var response = await client.PostAsJsonAsync("api/Donors/Login", login);
                var result = response.Content.ReadAsStringAsync().Result;
                DonorModel cus = JsonConvert.DeserializeObject<DonorModel>(result);


                if (cus != null)
                {
                    HttpContext.Session.SetString("Donor", result);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction();
                    }
                }
                else
                {
                    ViewBag.error = "Incorrect account or password";
                    ViewBag.status = returnUrl;
                    ModelState.AddModelError("", "Incorrect account or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
          

        }

        [HttpPost]
        public JsonResult CheckSession()
        {
            var session = HttpContext.Session.GetString("Donor");
            if(session != null)
            {
                var donor = JsonConvert.DeserializeObject<DonorModel>(session);
                return Json(donor);
            }
            else
            {
                return Json(null);
            }
           
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Donor"); // Hủy session với key AdminLogin đã lưu trước đó
            return RedirectToAction("Index","Home");
        }

    }
}