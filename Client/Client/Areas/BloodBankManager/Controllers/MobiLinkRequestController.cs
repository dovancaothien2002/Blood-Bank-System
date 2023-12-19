using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace Client.Areas.BloodBankManager.Controllers
{
    [Area("BloodBankManager")]
    public class MobiLinkRequestController : BaseController
    {
        string host_api = "http://localhost:49876/";
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index(string name, int page = 1)
        {

            int limit = 4;
            client.BaseAddress = new Uri(host_api);
            var data = await client.GetStringAsync("api/MobiLinkRequests/listshowed");
            if (!String.IsNullOrEmpty(name))
            {

                data = await client.GetStringAsync("api/MobiLinkRequests/search/" + name + "&" + 1);
            }
            var rq = JsonConvert.DeserializeObject<List<MobiLinkRequestModel>>(data);
            if (rq.Count < 1)
            {
                TempData["errD"] = "Not Found!!!";

            }
            IPagedList<MobiLinkRequestModel> list = await rq.ToPagedListAsync(page, limit);
            ViewBag.key = name;
            return View(list);
        }

        public async Task<IActionResult> Details(int id)
        {
            client.BaseAddress = new Uri(host_api);
            var result = await client.GetStringAsync("api/MobiLinkRequests/" + id);
            MobiLinkRequestModel rqModel = JsonConvert.DeserializeObject<MobiLinkRequestModel>(result);
            return View(rqModel);
        }
    }
}