using System;

namespace GetHealthy.Controllers
{
    public class Product
    {
        public string naam { get; private set; }
        public double calorieën { get; private set; }
        public double totaleVetten { get; private set; }
        public double verzadigdeVetten { get; private set; }
        public double koolhydraten { get; private set; }
        public double suikers { get; private set; }
        public double eiwitten { get; private set; }
        public double zouten { get; private set; }
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
