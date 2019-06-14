using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using JsonParse.Models;

namespace JsonParse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
           
        }

        public PartialViewResult Anasayfa()
        {
            string textFile = @"C:\Users\deads\Desktop\jsonOdev\jsons\anasayfa.txt";
            string text = System.IO.File.ReadAllText(textFile);
            var json = JsonConvert.DeserializeObject<HomePage>(text);

            return PartialView(json);
        }

       
        public ActionResult Detay()
        {
            string textFile = @"C:\Users\deads\Desktop\jsonOdev\jsons\detay.txt";
            string text = System.IO.File.ReadAllText(textFile);
            var json = JsonConvert.DeserializeObject<PageDetail>(text);

            ViewBag.Message = "Your contact page.";

            return PartialView(json);
        }
    }
}