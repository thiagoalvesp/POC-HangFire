using Hangfire;
using POC_HangFire.Models;
using POC_HangFire.Services;
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

        [HttpPost]
        public ActionResult AgendarTarefa(Agendar model, string ButtonType)
        {
            if (ButtonType == "Agendar")
                //Como usar a notação CRON
                //https://stackoverflow.com/questions/27221438/cron-every-day-at-6pm
                RecurringJob.AddOrUpdate("xpto", () => Tarefa.Executar(model.Texto), Cron.Minutely, null,"default");


            if (ButtonType == "Parar")
                RecurringJob.RemoveIfExists("xpto");

            if (ButtonType == "Executar")
                Tarefa.Executar(model.Texto);

            return View("Index", model);

        }

       
    }
}