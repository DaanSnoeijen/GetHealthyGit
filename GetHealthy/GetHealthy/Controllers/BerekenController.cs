using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Containers;
using GetHealthy.Interfaces;
using GetHealthy.DAL;

namespace GetHealthy.Controllers
{
    public class BerekenController
    {
        IGebruikerContainer gc;
        IUitkomstContainer uc;
        IProductContainer pc;
        IInvoerContainer ic;

        public BerekenController(IGebruikerContainer gebruikerContainer, IUitkomstContainer uitkomstContainer, IProductContainer productContainer, IInvoerContainer invoerContainer)
        {
            gc = gebruikerContainer;
            uc = uitkomstContainer;
            pc = productContainer;
            ic = invoerContainer;
        }

        public void Bereken()
        {
            //Voeg een nieuwe uitkomst toe
            uc.AddUitkomst();

            //Bereken of gebruiker actief is
            if (gc.GetGebruiker().werk == true)
            {
                gc.GetGebruiker().activiteit = true;
            }
            if (gc.GetGebruiker().sportPerWeek > 2)
            {
                gc.GetGebruiker().activiteit = true;
            }

            //Bereken leeftijd
            var today = DateTime.Today;
            gc.GetGebruiker().leeftijd = today.Year - gc.GetGebruiker().geboortedatum.Year;

            //Bereken voedingswaardes en BMI
            BerekenBMI();
            BerekenCalorieën();
            BerekenTotaleVetten();
            BerekenVerzadigdeVetten();
            BerekenKoolhydraten();
            BerekenSuikers();
            BerekenEiwitten();
            BerekenZouten();

            uc.AddToDatabase();
        }

        //BMI bepaald of persoon moet afvallen of aankomen
        private void BerekenBMI()
        {
            double meterLengte = gc.GetGebruiker().lengte / 100 * 2;

            gc.GetGebruiker().BMI = gc.GetGebruiker().gewicht / meterLengte;
        }

        private void BerekenCalorieën()
        {
            uc.AddUitkomst();

            if (gc.GetGebruiker().geslacht == 0)
            {
                uc.GetUitkomst().maximaleCalorieën = 566 + (14 * gc.GetGebruiker().gewicht) + (5 * Convert.ToInt32(gc.GetGebruiker().lengte)) - (7 * gc.GetGebruiker().leeftijd);
                uc.GetUitkomst().minimaleCalorieën = 66 + (14 * gc.GetGebruiker().gewicht) + (5 * Convert.ToInt32(gc.GetGebruiker().lengte)) - (7 * gc.GetGebruiker().leeftijd);
            }
            else
            {
                uc.GetUitkomst().maximaleCalorieën = 1155 + (10 * gc.GetGebruiker().gewicht) + (2 * Convert.ToInt32(gc.GetGebruiker().lengte)) - (5 * gc.GetGebruiker().leeftijd);
                uc.GetUitkomst().minimaleCalorieën = 655 + (10 * gc.GetGebruiker().gewicht) + (2 * Convert.ToInt32(gc.GetGebruiker().lengte)) - (5 * gc.GetGebruiker().leeftijd);
            }

            if (gc.GetGebruiker().BMI < 18.5)
            {
                uc.GetUitkomst().maximaleCalorieën += 200;
                uc.GetUitkomst().minimaleCalorieën += 200;
            }
            else if (gc.GetGebruiker().BMI > 25)
            {
                uc.GetUitkomst().maximaleCalorieën -= 200;
                uc.GetUitkomst().minimaleCalorieën -= 200;
            }
        }

        private void BerekenTotaleVetten()
        {
            uc.GetUitkomst().maximaleTotaleVetten = uc.GetUitkomst().maximaleCalorieën / 100 * 40 / 9;
            uc.GetUitkomst().minimaleTotaleVetten = uc.GetUitkomst().minimaleCalorieën / 100 * 20 / 9;
        }

        private void BerekenVerzadigdeVetten()
        {
            uc.GetUitkomst().maximaleVerzadigdeVetten = uc.GetUitkomst().maximaleCalorieën / 10 / 9;
            uc.GetUitkomst().minimaleVerzadigdeVetten = 0;
        }

        private void BerekenKoolhydraten()
        {
            uc.GetUitkomst().maximaleKoolhydraten = uc.GetUitkomst().maximaleCalorieën / 100 * 70 / 4;
            uc.GetUitkomst().minimaleKoolhydraten = uc.GetUitkomst().minimaleCalorieën / 100 * 40 / 4;
        }

        private void BerekenSuikers()
        {
            uc.GetUitkomst().maximaleSuikers = 90;
            uc.GetUitkomst().minimaleSuikers = 0;
        }

        private void BerekenEiwitten()
        {
            double maxGetal = 0.5;
            double minGetal = 0.5;

            if (gc.GetGebruiker().activiteit)
            {
                maxGetal += 1.0;
                minGetal += 0.5;
            }

            if (gc.GetGebruiker().leeftijd <= 1)
            {
                maxGetal += 1.8;
                minGetal += 1.2;
                uc.GetUitkomst().maximaleEiwitten = maxGetal * gc.GetGebruiker().gewicht;
                uc.GetUitkomst().minimaleEiwitten = minGetal * gc.GetGebruiker().gewicht;
            }
            else if (gc.GetGebruiker().leeftijd > 1 && gc.GetGebruiker().leeftijd <= 13)
            {
                maxGetal += 1.0;
                minGetal += 0.8;
                uc.GetUitkomst().maximaleEiwitten = maxGetal * gc.GetGebruiker().gewicht;
                uc.GetUitkomst().minimaleEiwitten = minGetal * gc.GetGebruiker().gewicht;
            }
            else if (gc.GetGebruiker().leeftijd > 13)
            {
                maxGetal += 0.9;
                minGetal += 0.7;
                uc.GetUitkomst().maximaleEiwitten = maxGetal * gc.GetGebruiker().gewicht;
                uc.GetUitkomst().minimaleEiwitten = minGetal * gc.GetGebruiker().gewicht;
            }
        }

        private void BerekenZouten()
        {
            if (gc.GetGebruiker().leeftijd <= 3)
            {
                uc.GetUitkomst().maximaleZouten = 3.0;
                uc.GetUitkomst().minimaleZouten = 2.5;
            }
            else if (gc.GetGebruiker().leeftijd > 3 && gc.GetGebruiker().leeftijd <= 8)
            {
                uc.GetUitkomst().maximaleZouten = 4.5;
                uc.GetUitkomst().minimaleZouten = 3.0;
            }
            else if (gc.GetGebruiker().leeftijd > 8)
            {
                uc.GetUitkomst().maximaleZouten = 6;
                uc.GetUitkomst().minimaleZouten = 3.0;
            }
        }
    }
}
