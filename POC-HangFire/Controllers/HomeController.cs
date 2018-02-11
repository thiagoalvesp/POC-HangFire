using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC_HangFire.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));

            BackgroundJob.Schedule(() => Console.WriteLine("Hello, world"),TimeSpan.FromSeconds(15));

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}