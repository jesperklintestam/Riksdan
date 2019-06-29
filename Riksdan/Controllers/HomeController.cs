using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Riksdan.Models;

namespace Riksdan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var webClient = new WebClient();
            string url = "http://data.riksdagen.se/personlista/?utformat=json";
            var json = webClient.DownloadString(url);
            var model = JsonConvert.DeserializeObject<RiksdanModel.JsonData>(json);
            return View(model);
        }
    }
}
