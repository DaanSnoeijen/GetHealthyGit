using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Interfaces;
using GetHealthy.Models;

namespace GetHealthy.Containers
{
    public class GebruikerContainer : IGebruikerContainer
    {
        public List<Gebruiker> GebruikerList = new List<Gebruiker>();

        public void AddGebruiker(int geslacht, int gewicht, int lengte, DateTime geboortedatum, int sportPerWeek, bool werk, bool vegan)
        {
            Gebruiker g = new Gebruiker(geslacht, gewicht, lengte, geboortedatum, sportPerWeek, werk, vegan);
            GebruikerList.Add(g);
        }
    }
}
