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

namespace Client.Areas.BloodBankManager.Controllers
{
    [Area("BloodBankManager")]
    public class BloodBankController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            ViewBag.bbName = bbAccount.bbName;
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/BloodStocks/searchbs/" + bbAccount.bbId);
            List<BloodStockModelB> list = JsonConvert.DeserializeObject<List<BloodStockModelB>>(json);

            var data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            List<RequestToBloodBankModel> listBRq0 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.newBRq = listBRq0.Count;

            data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            List<RequestToBloodBankModel> listBRq1 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.totalBRq = listBRq1.Count + listBRq0.Count;

            data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            List<RequestToBloodBankModel> listDRq0 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.newDRq = listDRq0.Count;

            data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            List<RequestToBloodBankModel> listDRq1 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.totalDrq = listDRq1.Count;

            data_json = await client.GetStringAsync("api/BloodStocks/searchlistblood/" + bbAccount.bbId);
            List<BloodModel> listBlood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.listBlood = new SelectList(listBlood, "bloodId", "bloodName");

            return View(list);
        }

        public async Task<IActionResult> Addbloobstock(int bId)
        {
           
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            client.BaseAddress = new Uri(host_api);
            BloodStock bs = new BloodStock
            {
                bbId = bbAccount.bbId,
                bloodId = bId,
                quantity = 0,
                create_at = DateTime.Now,
                update_at = DateTime.Now
            };
            BloodStock bs2 = bs;
            var json = await client.GetStringAsync("api/BloodStocks/checkBloodStock/" + bbAccount.bbId + "&" + bId);
            BloodStockModel bsCheck = JsonConvert.DeserializeObject<BloodStockModel>(json);
            if(bsCheck == null)
            {
                var result = await client.PostAsJsonAsync("api/BloodStocks/", bs);
                ViewBag.result = "Successfully added new !";
            }
            else
            {
                ViewBag.result = "Error";
            }
           
           
             json = await client.GetStringAsync("api/BloodStocks/searchbs/" + bbAccount.bbId);
            List<BloodStockModelB> list = JsonConvert.DeserializeObject<List<BloodStockModelB>>(json);

            var data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            List<RequestToBloodBankModel> listBRq0 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.newBRq = listBRq0.Count;

            data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            List<RequestToBloodBankModel> listBRq1 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.totalBRq = listBRq1.Count + listBRq0.Count;

            data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            List<RequestToBloodBankModel> listDRq0 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.newDRq = listDRq0.Count;

            data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            List<RequestToBloodBankModel> listDRq1 = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            ViewBag.totalDrq = listDRq1.Count;

            data_json = await client.GetStringAsync("api/BloodStocks/searchlistblood/" + bbAccount.bbId);
            List<BloodModel> listBlood = JsonConvert.DeserializeObject<List<BloodModel>>(data_json);
            ViewBag.listBlood = new SelectList(listBlood, "bloodId", "bloodName");
            return View("Index", list);
         
        }


    }
}