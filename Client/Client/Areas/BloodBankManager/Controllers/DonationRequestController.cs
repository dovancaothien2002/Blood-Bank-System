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
    public class DonationRequestController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();

        public async Task<IActionResult> Index(string name, int page = 1)
        {
            int limit = 2;
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            client.BaseAddress = new Uri(host_api);
            var donor = JsonConvert.DeserializeObject<DonorModel>(session);
            var data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 0);
            if (!String.IsNullOrEmpty(name))
            {

                data_json = await client.GetStringAsync("api/DonationRequests/searchName/" + bbAccount.bbId + "&" + name + "&" + 0);
            }
            List<DonationRequestModelB> listRq = JsonConvert.DeserializeObject<List<DonationRequestModelB>>(data_json);

            if (listRq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<DonationRequestModelB> newList = await listRq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(newList);
        }

        public async Task<IActionResult> rqHistory(string name, int page = 1)
        {
            int limit = 2;
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);
            client.BaseAddress = new Uri(host_api);

            var data_json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + bbAccount.bbId + "&" + 1);
            if (!String.IsNullOrEmpty(name))
            {

                data_json = await client.GetStringAsync("api/DonationRequests/searchName/" + bbAccount.bbId + "&" + name + "&" + 1);
            }
            List<DonationRequestModelB> listRq = JsonConvert.DeserializeObject<List<DonationRequestModelB>>(data_json);

            if (listRq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<DonationRequestModelB> newList = await listRq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(newList);
        }

        [HttpGet]
        public async Task<IActionResult> rqDetail(int Id)
        {
            var rqId = Id;
            client.BaseAddress = new Uri(host_api);
            var json = await client.GetStringAsync("api/DonationRequests/" + rqId);
            DonationRequestModelB rqModel = JsonConvert.DeserializeObject<DonationRequestModelB>(json);
            return View(rqModel);
        }


        [HttpGet]
        public async Task<IActionResult> Confirm(int rqId,int bloodId, int type)
        {
            client.BaseAddress = new Uri(host_api);
            var session = HttpContext.Session.GetString("BloodBankLogin");
            var bbAccount = JsonConvert.DeserializeObject<BloodBankModel>(session);

            var json = await client.GetStringAsync("api/DonationRequests/" + rqId);
            DonationRequest rqModel = JsonConvert.DeserializeObject<DonationRequest>(json);

            json = await client.GetStringAsync("api/DonationRequests/searchbybloodbank/" + rqModel.bbId + "&" + 0);
            List<DonationRequestModelB> listRq = JsonConvert.DeserializeObject<List<DonationRequestModelB>>(json);

           

            if (type == 1)
            {
                json = await client.GetStringAsync("api/BloodStocks/checkBloodStock/" + rqModel.bbId + "&" + bloodId);
                BloodStockModel bs = JsonConvert.DeserializeObject<BloodStockModel>(json);
                json = await client.GetStringAsync("api/DonationRequests/Confirm/" + rqId + "&" + type);
                listRq = JsonConvert.DeserializeObject<List<DonationRequestModelB>>(json);
                if (bs == null)
                {
                    BloodStock bsUpdates = new BloodStock
                    {
                       
                        bbId = bbAccount.bbId,
                        bloodId = bloodId,
                        update_at = DateTime.Now,
                        quantity = rqModel.amount

                    };

                    var result2 = await client.PostAsJsonAsync("api/BloodStocks/", bsUpdates);
                }
                else
                {
                    BloodStock bsUpdate = new BloodStock
                    {
                        bloodstockId = bs.bloodstockId,
                        bbId = bs.bbId,
                        bloodId = bs.bloodId,
                        update_at = DateTime.Now,
                        quantity = bs.quantity + rqModel.amount

                    };

                    var result = await client.PutAsJsonAsync("api/BloodStocks/" + bsUpdate.bloodstockId, bsUpdate);
                }
               
            }
            else if (type == 2)
            {
                json = await client.GetStringAsync("api/DonationRequests/Confirm/" + rqId + "&" + type);
                listRq = JsonConvert.DeserializeObject<List<DonationRequestModelB>>(json);
            }

            return RedirectToAction("Index","DonationRequest", listRq);

        }

    }
}