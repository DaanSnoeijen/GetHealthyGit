using GetHealthy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Interfaces
{
    public interface IGebruikerContainer
    {
        void AddGebruiker(int geslacht, int gewicht, int lengte, DateTime geboortedatum, int sportPerWeek, bool werk, bool vegan);
    }
}
