using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.Dashboard;
using Hangfire.SQLite;
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
            //app.UseHangfireServer();
            //var option = new BackgroundJobServerOptions { WorkerCount = 1 };

            //app.UseHangfireServer(option);

            //var filter = new BasicAuthAuthorizationFilter(
            //new BasicAuthAuthorizationFilterOptions
            //{
            //    // Require secure connection for dashboard
            //    RequireSsl = false,
            //    // Case sensitive login checking
            //    LoginCaseSensitive = true,
            //    // Users
            //    Users = new[]
            //    {
            //        new BasicAuthAuthorizationUser
            //        {
            //            Login = "thiago",
            //            // Password as plain text
            //            PasswordClear = "test"
            //        },
            //        new BasicAuthAuthorizationUser
            //        {
            //            Login = "Administrator-2",
            //            // Password as SHA1 hash
            //            Password = new byte[]{0xa9,
            //                0x4a, 0x8f, 0xe5, 0xcc, 0xb1, 0x9b,
            //                0xa6, 0x1c, 0x4c, 0x08, 0x73, 0xd3,
            //                0x91, 0xe9, 0x87, 0x98, 0x2f, 0xbb,
            //                0xd3}
            //        }
            //    }
            //});

            //var options = new DashboardOptions
            //{
            //    AuthorizationFilters = new[] { filter }
            //};

            app.UseHangfireDashboard();

            app.UseHangfireDashboard();

        }
    }
}
