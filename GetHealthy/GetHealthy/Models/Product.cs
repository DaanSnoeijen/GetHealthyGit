using System;

namespace GetHealthy.Controllers
{
    public class Product
    {
        public string naam { get; set; }
        public double calorieën { get; set; }
        public double totaleVetten { get; set; }
        public double verzadigdeVetten { get; set; }
        public double koolhydraten { get; set; }
        public double suikers { get; set; }
        public double eiwitten { get; set; }
        public double zouten { get; set; }

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
    }
}
