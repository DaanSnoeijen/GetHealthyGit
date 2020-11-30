using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.DTO
{
    public class InvoerDTO
    {
        public double calorieën;
        public double totaleVetten;
        public double verzadigdeVetten;
        public double koolhydraten;
        public double suikers;
        public double eiwitten;
        public double zouten;
        public DateTime today = DateTime.Now;

        public InvoerDTO(double Calorieën, double TotaleVetten, double VerzadigdeVetten, double Koolhydraten, double Suikers, double Eiwitten, double Zouten)
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
