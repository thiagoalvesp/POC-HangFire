using Hangfire.RecurringJobExtensions;
using Hangfire.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_HangFire.Models
{
    public class RecurringJobService
    {

        [RecurringJob("*/1 * * * *")]
        public void TestJob1(PerformContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} TestJob1 Running ...");
        }
        [RecurringJob("*/2 * * * *", RecurringJobId = "TestJob2", Queue = "jobs")]
        public void TestJob2(PerformContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} TestJob2 Running ...");
        }

        [RecurringJob("*/2 * * * *", "China Standard Time", "jobs")]
        public void TestJob3(PerformContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} TestJob3 Running ...");
        }
        [RecurringJob("*/5 * * * *", "jobs")]
        public void InstanceTestJob(PerformContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} InstanceTestJob Running ...");
        }

        [RecurringJob("*/6 * * * *", "UTC", "jobs")]
        public static void StaticTestJob(PerformContext context)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} StaticTestJob Running ...");
        }
    }
}