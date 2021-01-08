using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Models
{
    public class Invoer
    {
        public double calorieën { get; private set; }
        public double totaleVetten { get; private set; }
        public double verzadigdeVetten { get; private set; }
        public double koolhydraten { get; private set; }
        public double suikers { get; private set; }
        public double eiwitten { get; private set; }
        public double zouten { get; private set; }

        public Invoer(double Calorieën, double TotaleVetten, double VerzadigdeVetten, double Koolhydraten, double Suikers, double Eiwitten, double Zouten)
        {
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
