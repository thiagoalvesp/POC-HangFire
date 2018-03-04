using Hangfire;
using Hangfire.Dashboard.Dark;
using Hangfire.MemoryStorage;
using Hangfire.RecurringJobExtensions;
using Hangfire.SQLite;
using POC_HangFire.App_Start;
using POC_HangFire.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace POC_HangFire
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Storage is the only thing required for basic configuration.
            // Just discover what configuration options do you have.


            // GlobalConfiguration.Configuration
            //.UseSqlServerStorage("ConnectionStringDefault");
            //var options = new SQLiteStorageOptions();
            //GlobalConfiguration.Configuration.UseSQLiteStorage("SQLiteHangfire", options);

            //GlobalConfiguration.Configuration.UseDarkDashboard();
            //GlobalConfiguration.Configuration.UseMemoryStorage();

            HangfireBootstrapper.Instance.Start();

            //CronJob.AddOrUpdate(typeof(RecurringJobService));



        }

        protected void Application_End()
        {
            HangfireBootstrapper.Instance.Stop();
        }


    }
}
