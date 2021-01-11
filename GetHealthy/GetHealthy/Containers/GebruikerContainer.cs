using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.DAL;
using GetHealthy.DTO;
using GetHealthy.Interfaces;
using GetHealthy.Models;

namespace GetHealthy.Containers
{
    public class GebruikerContainer : IGebruikerContainer
    {
        Gebruiker gebruiker;

        IGebruiker dal;

        public GebruikerContainer(IGebruiker DAL)
        {
            dal = DAL;
        }

        public GebruikerContainer()
        {
            dal = new GebruikerDAL();
        }

        public void AddGebruiker(int geslacht, int gewicht, int lengte, DateTime geboortedatum, int sportPerWeek, bool werk, bool vegan)
        {
            gebruiker = new Gebruiker(geslacht, gewicht, lengte, geboortedatum, sportPerWeek, werk, vegan);

            GebruikerDTO dto = new GebruikerDTO(
                    gebruiker.geslacht,
                    gebruiker.gewicht,
                    gebruiker.lengte,
                    gebruiker.geboortedatum,
                    gebruiker.sportPerWeek,
                    gebruiker.werk,
                    gebruiker.vegan);

            dal.StoreGebruiker(dto);
        }

        public Gebruiker GetGebruiker()
        {
            try
            {
                return gebruiker;
            }
            catch
            {
                return null;
            }
        }
    }
}
