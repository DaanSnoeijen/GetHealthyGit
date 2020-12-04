using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.DTO
{
    public class UitkomstDTO
    {
        public int maximaleCalorieën;
        public int minimaleCalorieën;
        public int maximaleTotaleVetten;
        public int minimaleTotaleVetten;
        public int maximaleVerzadigdeVetten;
        public int maximaleKoolhydraten;
        public int minimaleKoolhydraten;
        public int maximaleSuikers;
        public double maximaleEiwitten;
        public double minimaleEiwitten;
        public double maximaleZouten;
        public double minimaleZouten;

        public UitkomstDTO (
            int MaximaleCalorieën, 
            int MinimaleCalorieën, 
            int MaximaleTotaleVetten, 
            int MinimaleTotaleVetten, 
            int MaximaleVerzadigdeVetten, 
            int MaximaleKoolhydraten, 
            int MinimaleKoolhydraten, 
            int MaximaleSuikers, 
            double MaximaleEiwitten,
            double MinimaleEiwitten,
            double MaximaleZouten,
            double MinimaleZouten)
        {
            maximaleCalorieën = MaximaleCalorieën;
            minimaleCalorieën = MinimaleCalorieën;
            maximaleTotaleVetten = MaximaleTotaleVetten;
            minimaleTotaleVetten = MinimaleTotaleVetten;
            maximaleVerzadigdeVetten = MaximaleVerzadigdeVetten;
            maximaleKoolhydraten = MaximaleKoolhydraten;
            minimaleKoolhydraten = MinimaleKoolhydraten;
            maximaleSuikers = MaximaleSuikers;
            maximaleEiwitten = MaximaleEiwitten;
            minimaleEiwitten = MinimaleEiwitten;
            maximaleEiwitten = MaximaleEiwitten;
            minimaleEiwitten = MinimaleEiwitten;
            maximaleZouten = MaximaleZouten;
            minimaleZouten = MinimaleZouten;
        }
    }
}
