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
        GebruikerContainer gc;
        UitkomstContainer uc;
        ProductContainer pc;
        InvoerContainer ic;

        public BerekenController(GebruikerContainer gebruikerContainer, UitkomstContainer uitkomstContainer, ProductContainer productContainer, InvoerContainer invoerContainer)
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
            if (gc.GebruikerList[0].werk == true)
            {
                gc.GebruikerList[0].activiteit = true;
            }
            if (gc.GebruikerList[0].sportPerWeek > 2)
            {
                gc.GebruikerList[0].activiteit = true;
            }

            //Bereken leeftijd
            var today = DateTime.Today;
            gc.GebruikerList[0].leeftijd = today.Year - gc.GebruikerList[0].geboortedatum.Year;

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
            double meterLengte = gc.GebruikerList[0].lengte / 100 * 2;

            gc.GebruikerList[0].BMI = gc.GebruikerList[0].gewicht / meterLengte;
        }

        private void BerekenCalorieën()
        {
            uc.AddUitkomst();

            if (gc.GebruikerList[0].geslacht == 0)
            {
                uc.UitkomstList[0].maximaleCalorieën = 566 + (14 * gc.GebruikerList[0].gewicht) + (5 * Convert.ToInt32(gc.GebruikerList[0].lengte)) - (7 * gc.GebruikerList[0].leeftijd);
                uc.UitkomstList[0].minimaleCalorieën = 66 + (14 * gc.GebruikerList[0].gewicht) + (5 * Convert.ToInt32(gc.GebruikerList[0].lengte)) - (7 * gc.GebruikerList[0].leeftijd);
            }
            else
            {
                uc.UitkomstList[0].maximaleCalorieën = 1155 + (10 * gc.GebruikerList[0].gewicht) + (2 * Convert.ToInt32(gc.GebruikerList[0].lengte)) - (5 * gc.GebruikerList[0].leeftijd);
                uc.UitkomstList[0].minimaleCalorieën = 655 + (10 * gc.GebruikerList[0].gewicht) + (2 * Convert.ToInt32(gc.GebruikerList[0].lengte)) - (5 * gc.GebruikerList[0].leeftijd);
            }

            if (gc.GebruikerList[0].BMI < 18.5)
            {
                uc.UitkomstList[0].maximaleCalorieën += 200;
                uc.UitkomstList[0].minimaleCalorieën += 200;
            }
            else if (gc.GebruikerList[0].BMI > 25)
            {
                uc.UitkomstList[0].maximaleCalorieën -= 200;
                uc.UitkomstList[0].minimaleCalorieën -= 200;
            }
        }

        private void BerekenTotaleVetten()
        {
            uc.UitkomstList[0].maximaleTotaleVetten = uc.UitkomstList[0].maximaleCalorieën / 100 * 40 / 9;
            uc.UitkomstList[0].minimaleTotaleVetten = uc.UitkomstList[0].minimaleCalorieën / 100 * 20 / 9;
        }

        private void BerekenVerzadigdeVetten()
        {
            uc.UitkomstList[0].maximaleVerzadigdeVetten = uc.UitkomstList[0].maximaleCalorieën / 10 / 9;
            uc.UitkomstList[0].minimaleVerzadigdeVetten = 0;
        }

        private void BerekenKoolhydraten()
        {
            uc.UitkomstList[0].maximaleKoolhydraten = uc.UitkomstList[0].maximaleCalorieën / 100 * 70 / 4;
            uc.UitkomstList[0].minimaleKoolhydraten = uc.UitkomstList[0].minimaleCalorieën / 100 * 40 / 4;
        }

        private void BerekenSuikers()
        {
            uc.UitkomstList[0].maximaleSuikers = 90;
            uc.UitkomstList[0].minimaleSuikers = 0;
        }

        private void BerekenEiwitten()
        {
            double maxGetal = 0.5;
            double minGetal = 0.5;

            if (gc.GebruikerList[0].activiteit)
            {
                maxGetal += 1.0;
                minGetal += 0.5;
            }

            if (gc.GebruikerList[0].leeftijd <= 1)
            {
                maxGetal += 1.8;
                minGetal += 1.2;
                uc.UitkomstList[0].maximaleEiwitten = maxGetal * gc.GebruikerList[0].gewicht;
                uc.UitkomstList[0].minimaleEiwitten = minGetal * gc.GebruikerList[0].gewicht;
            }
            else if (gc.GebruikerList[0].leeftijd > 1 && gc.GebruikerList[0].leeftijd <= 13)
            {
                maxGetal += 1.0;
                minGetal += 0.8;
                uc.UitkomstList[0].maximaleEiwitten = maxGetal * gc.GebruikerList[0].gewicht;
                uc.UitkomstList[0].minimaleEiwitten = minGetal * gc.GebruikerList[0].gewicht;
            }
            else if (gc.GebruikerList[0].leeftijd > 13)
            {
                maxGetal += 0.9;
                minGetal += 0.7;
                uc.UitkomstList[0].maximaleEiwitten = maxGetal * gc.GebruikerList[0].gewicht;
                uc.UitkomstList[0].minimaleEiwitten = minGetal * gc.GebruikerList[0].gewicht;
            }
        }

        private void BerekenZouten()
        {
            if (gc.GebruikerList[0].leeftijd <= 3)
            {
                uc.UitkomstList[0].maximaleZouten = 3.0;
                uc.UitkomstList[0].minimaleZouten = 2.5;
            }
            else if (gc.GebruikerList[0].leeftijd > 3 && gc.GebruikerList[0].leeftijd <= 8)
            {
                uc.UitkomstList[0].maximaleZouten = 4.5;
                uc.UitkomstList[0].minimaleZouten = 3.0;
            }
            else if (gc.GebruikerList[0].leeftijd > 8)
            {
                uc.UitkomstList[0].maximaleZouten = 6;
                uc.UitkomstList[0].minimaleZouten = 3.0;
            }
        }
    }
}
