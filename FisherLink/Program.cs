using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace FisherLink
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseSetting("detailedErrors", "true")  //debug setting
                .UseIISIntegration()
                .UseStartup<Startup>()
                .CaptureStartupErrors(true)  //debug setting
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
