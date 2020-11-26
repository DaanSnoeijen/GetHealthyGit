using System;

namespace GetHealthy.Controllers
{
    public class Product
    {
        public string naam;
        public double calorieën;
        public double totaleVetten;
        public double verzadigdeVetten;
        public double koolhydraten;
        public double suikers;
        public double eiwitten;
        public double zouten;
        public double hoeveelheid;

        public Product(string Naam, double Calorieën, double TotaleVetten, double VerzadigdeVetten, double Koolhydraten, double Suikers, double Eiwitten, double Zouten)
        {
            naam = Naam;
            calorieën = Calorieën;
            totaleVetten = TotaleVetten;
            verzadigdeVetten = VerzadigdeVetten;
            koolhydraten = Koolhydraten;
            suikers = Suikers;
            eiwitten = Eiwitten;
            zouten = Zouten;
        }

        public void BerekenHoeveelheid()
        {
            double hoeveelheidVermenigvuldig;

            if (hoeveelheid == 1)
            {
                hoeveelheidVermenigvuldig = 5;

                calorieën *= hoeveelheidVermenigvuldig;
                totaleVetten *= hoeveelheidVermenigvuldig;
                verzadigdeVetten *= hoeveelheidVermenigvuldig;
                koolhydraten *= hoeveelheidVermenigvuldig;
                suikers *= hoeveelheidVermenigvuldig;
                eiwitten *= hoeveelheidVermenigvuldig;
                zouten *= hoeveelheidVermenigvuldig;
            }
            else if (hoeveelheid == 2)
            {
                hoeveelheidVermenigvuldig = 2.5;

                calorieën *= hoeveelheidVermenigvuldig;
                totaleVetten *= hoeveelheidVermenigvuldig;
                verzadigdeVetten *= hoeveelheidVermenigvuldig;
                koolhydraten *= hoeveelheidVermenigvuldig;
                suikers *= hoeveelheidVermenigvuldig;
                eiwitten *= hoeveelheidVermenigvuldig;
                zouten *= hoeveelheidVermenigvuldig;
            }
            else if (hoeveelheid == 4)
            {
                hoeveelheidVermenigvuldig = 0.5;

                calorieën *= hoeveelheidVermenigvuldig;
                totaleVetten *= hoeveelheidVermenigvuldig;
                verzadigdeVetten *= hoeveelheidVermenigvuldig;
                koolhydraten *= hoeveelheidVermenigvuldig;
                suikers *= hoeveelheidVermenigvuldig;
                eiwitten *= hoeveelheidVermenigvuldig;
                zouten *= hoeveelheidVermenigvuldig;
            }
            else if (hoeveelheid == 5)
            {
                hoeveelheidVermenigvuldig = 0.1;

                calorieën *= hoeveelheidVermenigvuldig;
                totaleVetten *= hoeveelheidVermenigvuldig;
                verzadigdeVetten *= hoeveelheidVermenigvuldig;
                koolhydraten *= hoeveelheidVermenigvuldig;
                suikers *= hoeveelheidVermenigvuldig;
                eiwitten *= hoeveelheidVermenigvuldig;
                zouten *= hoeveelheidVermenigvuldig;
            }
        }

        public override string ToString()
        {
            return naam + ", calorieën: " +
                Convert.ToString(calorieën) + ", totale vetten: " +
                Convert.ToString(totaleVetten) + ", gemiddelde vetten: " +
                Convert.ToString(verzadigdeVetten) + ", koolhydraten: " +
                Convert.ToString(koolhydraten) + ", suikers: " +
                Convert.ToString(suikers) + ", eiwitten: " +
                Convert.ToString(eiwitten) + ", zouten: " +
                Convert.ToString(zouten) + ", hoeveelheid: " +
                Convert.ToString(hoeveelheid);
        }
    }
}
