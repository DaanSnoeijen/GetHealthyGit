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
using GetHealthy.DAL;
using GetHealthy.Interfaces;
using GetHealthy.Models;

namespace GetHealthy
{
    public class Program
    {
        public static GebruikerContainer gebruikerContainer = new GebruikerContainer();
        public static InvoerContainer invoerContainer = new InvoerContainer(iInvoer);
        public static UitkomstContainer uitkomstContainer = new UitkomstContainer(iUitkomst);
        public static ProductContainer productContainer = new ProductContainer(iProduct);

        public static BerekenController berekenController = new BerekenController(gebruikerContainer, uitkomstContainer, productContainer, invoerContainer);

        static IInvoer iInvoer = new InvoerDAL();
        static IUitkomst iUitkomst = new UitkomstDAL();
        static IProduct iProduct = new ProductenDAL();

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
