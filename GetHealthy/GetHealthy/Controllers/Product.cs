using System;

namespace GetHealthy.Controllers
{
    class Product
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
