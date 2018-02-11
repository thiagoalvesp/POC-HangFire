using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(POC_HangFire.App_Start.Startup))]

namespace POC_HangFire.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseHangfireServer();
            app.UseHangfireDashboard();
        }
    }
}
