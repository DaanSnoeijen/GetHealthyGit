using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.DTO
{
    public class GebruikerDTO
    {
        public int geslacht { get; private set; }
        public int gewicht { get; private set; }
        public double lengte { get; private set; }
        public DateTime geboortedatum { get; private set; }
        public int leeftijd { get; set; }
        public int sportPerWeek { get; private set; }
        public bool werk { get; private set; }
        public bool vegan { get; private set; }
        public bool activiteit { get; set; }
        public double BMI { get; set; }

        public GebruikerDTO(int Geslacht, int Gewicht, double Lengte, DateTime Geboortedatum, int SportPerWeek, bool Werk, bool Vegan)
        {
            geslacht = Geslacht;
            gewicht = Gewicht;
            lengte = Lengte;
            geboortedatum = Geboortedatum;
            sportPerWeek = SportPerWeek;
            werk = Werk;
            vegan = Vegan;
            activiteit = false;
        }
    }
}
