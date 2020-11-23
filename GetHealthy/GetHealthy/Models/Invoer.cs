using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Models
{
    public class Invoer
    {
        public double calorieën;
        public double totaleVetten;
        public double verzagdigdeVetten;
        public double koolhydraten;
        public double suikers;
        public double eiwitten;
        public double zouten;

        public Invoer(double Calorieën, double TotaleVetten, double VerzadigdeVetten, double Koolhydraten, double Suikers, double Eiwitten, double Zouten)
        {
            calorieën = Calorieën;
            totaleVetten = TotaleVetten;
            verzagdigdeVetten = VerzadigdeVetten;
            koolhydraten = Koolhydraten;
            suikers = Suikers;
            eiwitten = Eiwitten;
            zouten = Zouten;
        }
    }
}
