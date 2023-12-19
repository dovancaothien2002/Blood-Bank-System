using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Areas.Admin.Models;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Login = Client.Areas.Admin.Models.Login;

namespace Client.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class LoginController : Controller
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        [HttpGet] // GET Hiển thị form để nhập dữ liệu
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> Index(Login model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }else
            {
                client.BaseAddress = new Uri(host_api);
                var respone = await client.PostAsJsonAsync("api/account/login", model);
                var result = respone.Content.ReadAsStringAsync().Result;
                Account acc = JsonConvert.DeserializeObject<Account>(result);
                if (acc != null)
                {
                    HttpContext.Session.SetString("AdminLogin", acc.Name);
                    return RedirectToAction("Index", "Admin"); 
                }
                else
                {
                    TempData["err"] = "Incorrect account or password";
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin"); // Hủy session với key AdminLogin đã lưu trước đó
            return RedirectToAction("Index");
        }


    }
}