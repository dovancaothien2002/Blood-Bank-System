using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace Client.Areas.BloodBankManager.Controllers
{
    [Area("BloodBankManager")]
    public class BloodRequestController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index(string name,int page = 1)
        {
            int limit = 2;
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            client.BaseAddress = new Uri(host_api);
           
            var data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            if (!String.IsNullOrEmpty(name))
            {

                data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchName/" + bbAccount.bbId + "&" + name + "&" + 0);
            }
            List<RequestToBloodBankModel> listRq = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            if (listRq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<RequestToBloodBankModel> newList = await listRq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(newList);
        }

        public async Task<IActionResult> rqHistory(string name, int page = 1)
        {
            int limit = 2;
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            client.BaseAddress = new Uri(host_api);

            var data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            if (!String.IsNullOrEmpty(name))
            {

                data_json = await client.GetStringAsync("api/RequestToBloodBanks/searchName/" + bbAccount.bbId + "&" + name + "&" + 1);
            }
            List<RequestToBloodBankModel> listRq = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(data_json);
            if (listRq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<RequestToBloodBankModel> newList = await listRq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(newList);
        }

        [HttpGet]
        public async Task<IActionResult> rqDetail(int Id)
        {
            var id = Id;
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/RequestToBloodBanks/" + id);
            RequestToBloodBankModel rqModel = JsonConvert.DeserializeObject<RequestToBloodBankModel>(json);
            return View(rqModel);
        }

        [HttpGet]
        public async Task<IActionResult> Confirm(int rqId, int type)
        {
            client.BaseAddress = new Uri(host_api);

            var json = await client.GetStringAsync("api/RequestToBloodBanks/" + rqId);
            RequestToBloodBankModel rqModel = JsonConvert.DeserializeObject<RequestToBloodBankModel>(json);

             json = await client.GetStringAsync("api/RequestToBloodBanks/searchbybloodbank/" + rqModel.bbId + "&" + 0);
            List<RequestToBloodBankModel> listRq = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(json);

            json = await client.GetStringAsync("api/BloodStocks/checkBloodStock/" + rqModel.bbId + "&" + rqModel.bloodId);
            BloodStockModel bs = JsonConvert.DeserializeObject<BloodStockModel>(json);

            if (type == 1)
            {
                if (bs.quantity >= rqModel.amount)
                {
                    json = await client.GetStringAsync("api/RequestToBloodBanks/Confirm/" + rqId + "&" + type);
                    listRq = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(json);

                    BloodStock bsUpdate = new BloodStock
                    {
                        bloodstockId = bs.bloodstockId,
                        bbId = bs.bbId,
                        bloodId = bs.bloodId,
                        update_at = DateTime.Now,
                        quantity = bs.quantity - rqModel.amount

                    };

                    var result = await client.PutAsJsonAsync("api/BloodStocks/"+bsUpdate.bloodstockId, bsUpdate);
                }
                else
                {
                    ViewBag.Error = "Blood stock does not enough volume of " + rqModel.bloodName + " blood group";
                }
            }else if(type == 2)
            {
                json = await client.GetStringAsync("api/RequestToBloodBanks/Confirm/" + rqId + "&" + type);
                listRq = JsonConvert.DeserializeObject<List<RequestToBloodBankModel>>(json);
            }

            return View("Index", listRq);
           
        }

    }
}