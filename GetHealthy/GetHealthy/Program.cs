using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using GetHealthy.Controllers;
using GetHealthy.Containers;

namespace GetHealthy
{
    class Program
    {
        public static ProductContainer productContainer = new ProductContainer();
        public static GebruikerContainer gebruikerContainer = new GebruikerContainer();
        public static UitkomstContainer uitkomstContainer = new UitkomstContainer();
        public static InvoerContainer invoerContainer = new InvoerContainer();
        public static BerekenController berekenController = new BerekenController();

        public static void Main(string[] args)
        {
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
