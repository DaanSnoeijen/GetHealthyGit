using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Models
{
    class Gebruiker
    {
        public int geslacht;
        public int gewicht;
        public double lengte;
        public DateTime geboortedatum;
        public int leeftijd;
        public int sportPerWeek;
        public bool werk;
        public bool vegan;
        public bool activiteit = false;
        public double BMI;

        public Gebruiker(int Geslacht, int Gewicht, double Lengte, DateTime Geboortedatum, int SportPerWeek, bool Werk, bool Vegan)
        {
            geslacht = Geslacht;
            gewicht = Gewicht;
            lengte = Lengte;
            geboortedatum = Geboortedatum;
            sportPerWeek = SportPerWeek;
            werk = Werk;
            vegan = Vegan;
        }
    }
}
