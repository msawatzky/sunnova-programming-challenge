using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using SunovaChallenge.Models;
using System.Xml;
using Newtonsoft.Json;
using System.Net;

namespace SunovaChallenge.Controllers
{
    
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            List<Car> cars = new List<Car>();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://mobiledev.sunovacu.ca/api/Values/GetCars");

                cars = JsonConvert.DeserializeObject<List<Car>>(json);
            }
            return View(cars);
        }
    }
}