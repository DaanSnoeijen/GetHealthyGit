using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Models
{
    public class ProductDTO
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

        public ProductDTO(string Naam, double Calorieën, double TotaleVetten, double VerzadigdeVetten, double Koolhydraten, double Suikers, double Eiwitten, double Zouten)
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
