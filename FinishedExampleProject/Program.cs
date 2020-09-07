using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FinishedExampleProject
{
    public class Program
    {
        public static Dictionary<string,int> CouponDictionary=new Dictionary<string, int>();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var rnd = new Random();
                CouponDictionary.Add(Guid.NewGuid().ToString(), rnd.Next(10, 70));

            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
