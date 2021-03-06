﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using GetHealthy.Interfaces;
using GetHealthy.DAL;
using GetHealthy.DTO;

namespace GetHealthy.Containers
{
    public class InvoerContainer : IInvoerContainer
    {
        public List<Invoer> InvoerList = new List<Invoer>();

        IInvoer iInvoer;

        public InvoerContainer(IInvoer invoer)
        {
            iInvoer = invoer;
        }

        public InvoerContainer()
        {
            IInvoer iInvoer = new InvoerDAL();
        }

        public void AddInvoer(double calorieën, double totaleVetten, double verzadigdeVetten, double koolhydraten, double suikers, double eiwitten, double zouten)
        {
            Invoer invoer = new Invoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);
            InvoerDTO invoerDTO = new InvoerDTO(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);

            InvoerList.Add(invoer);

            iInvoer.StoreInvoer(invoerDTO);
        }
    }
}
