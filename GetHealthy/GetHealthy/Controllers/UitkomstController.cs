using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GetHealthy.Containers;
using GetHealthy.ViewModels;

namespace GetHealthy.Controllers
{
    public class UitkomstController : Controller
    {
        public IActionResult Uitkomst()
        {
            //Dummy gebruiker
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);
            //Einde dummy gebruiker

            double calorieën = 0;
            double totaleVetten = 0;
            double verzadigdeVetten = 0;
            double koolhydraten = 0;
            double suikers = 0;
            double eiwitten = 0;
            double zouten = 0;

            foreach (Product product in Program.productContainer.SelectedProducts)
            {
                calorieën += product.calorieën;
                totaleVetten += product.totaleVetten;
                verzadigdeVetten += product.verzadigdeVetten;
                koolhydraten += product.koolhydraten;
                suikers += product.suikers;
                eiwitten += product.eiwitten;
                zouten += product.zouten;
            }

            Program.invoerContainer.AddInvoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);

            Program.berekenController.Bereken();

            UitkomstViewModel uitkomstViewModel = new UitkomstViewModel(
                Program.uitkomstContainer.UitkomstList[0].maximaleCalorieën,
                Program.uitkomstContainer.UitkomstList[0].minimaleCalorieën,
                Program.uitkomstContainer.UitkomstList[0].maximaleTotaleVetten,
                Program.uitkomstContainer.UitkomstList[0].minimaleTotaleVetten,
                Program.uitkomstContainer.UitkomstList[0].maximaleVerzagdigdeVetten,
                Program.uitkomstContainer.UitkomstList[0].minimaleVerzagdigdeVetten,
                Program.uitkomstContainer.UitkomstList[0].maximaleKoolhydraten,
                Program.uitkomstContainer.UitkomstList[0].minimaleKoolhydraten,
                Program.uitkomstContainer.UitkomstList[0].maximaleSuikers,
                Program.uitkomstContainer.UitkomstList[0].minimaleSuikers,
                Program.uitkomstContainer.UitkomstList[0].maximaleEiwitten,
                Program.uitkomstContainer.UitkomstList[0].minimaleEiwitten,
                Program.uitkomstContainer.UitkomstList[0].maximaleZouten,
                Program.uitkomstContainer.UitkomstList[0].minimaleZouten);

            return View("Uitkomst", uitkomstViewModel);
        }
    }
}
