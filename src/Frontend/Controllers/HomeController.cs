using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private const string serviceUrlBase = "http://counter.service.consul:5000";

        public async Task<ViewResult> Index()
        {
            var model = new CounterModel();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(serviceUrlBase + "/api/metadata");
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                var metadata =  Newtonsoft.Json.JsonConvert.DeserializeObject<Metadata>(resp);
                model.SessionId = metadata.SessionId;
                model.IP = metadata.IP;
            }
            
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Refresh()
        {
            return this.RedirectToAction("Index");
        }
    }
}
