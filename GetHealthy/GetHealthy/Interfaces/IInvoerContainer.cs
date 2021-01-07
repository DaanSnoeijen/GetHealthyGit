using GetHealthy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Interfaces
{
    public interface IInvoerContainer
    {
        void AddInvoer(double calorieën, double totaleVetten, double verzadigdeVetten, double koolhydraten, double suikers, double eiwitten, double zouten);

        List<Invoer> InvoerList();
    }
}
