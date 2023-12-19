using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Areas.BloodBankManager.Models;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Login = Client.Areas.BloodBankManager.Models.Login;

namespace Client.Areas.BloodBankManager.Controllers
{
    [Area("BloodBankManager")]

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
            }

            else
            {
                client.BaseAddress = new Uri(host_api);
                var respone = await client.PostAsJsonAsync("api/bloodbanks/login", model);
                var result = respone.Content.ReadAsStringAsync().Result;
                BloodBankModel bb = JsonConvert.DeserializeObject<BloodBankModel>(result);
                if (bb == null)
                {
                    TempData["err"] = "Incorrect account or password";
                }
                else
                {
                    HttpContext.Session.SetString("BloodBankLogin", result);
                    return RedirectToAction ("Index","BloodBank");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("BloodBankLogin"); // Hủy session với key AdminLogin đã lưu trước đó
            return RedirectToAction("Index");
        }


    }
}