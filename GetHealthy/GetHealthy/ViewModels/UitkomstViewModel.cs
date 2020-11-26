using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;

namespace GetHealthy.ViewModels
{
    public class UitkomstViewModel
    {
        public int maximaleCalorieën;
        public int minimaleCalorieën;
        public int maximaleTotaleVetten;
        public int minimaleTotaleVetten;
        public int maximaleVerzadigdeVetten;
        public int minimaleVerzadigdeVetten;
        public int maximaleKoolhydraten;
        public int minimaleKoolhydraten;
        public int maximaleSuikers;
        public int minimaleSuikers;
        public double maximaleEiwitten;
        public double minimaleEiwitten;
        public double maximaleZouten;
        public double minimaleZouten;

        public Invoer invoer = Program.invoerContainer.InvoerList[0];

        public UitkomstViewModel(
            int MaximaleCalorieën,
            int MinimaleCalorieën,
            int MaximaleTotaleVetten,
            int MinimaleTotaleVetten,
            int MaximaleVerzadigdeVetten,
            int MinimaleVerzadigdeVetten,
            int MaximaleKoolhydraten,
            int MinimaleKoolhydraten,
            int MaximaleSuikers,
            int MinimaleSuikers,
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
            minimaleVerzadigdeVetten = MinimaleVerzadigdeVetten;
            maximaleKoolhydraten = MaximaleKoolhydraten;
            minimaleKoolhydraten = MinimaleKoolhydraten;
            maximaleSuikers = MaximaleSuikers;
            minimaleSuikers = MinimaleSuikers;
            maximaleEiwitten = MaximaleEiwitten;
            minimaleEiwitten = MinimaleEiwitten;
            maximaleZouten = MaximaleZouten;
            minimaleZouten = MinimaleZouten;
        }
    }
}
