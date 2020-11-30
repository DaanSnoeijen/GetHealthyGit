using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using GetHealthy.Interfaces;
using GetHealthy.DAL;

namespace GetHealthy.Containers
{
    public class InvoerContainer
    {
        public List<Invoer> InvoerList = new List<Invoer>();

        IInvoer iInvoer = new InvoerDAL();

        public void AddInvoer(double calorieën, double totaleVetten, double verzadigdeVetten, double koolhydraten, double suikers, double eiwitten, double zouten)
        {
            Invoer invoer = new Invoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);
            InvoerList.Add(invoer);

            iInvoer.StoreInvoer();
        }
    }
}
