﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;

namespace GetHealthy.Containers
{
    public class InvoerContainer
    {
        public List<Invoer> InvoerList = new List<Invoer>();

        public void AddInvoer(double calorieën, double totaleVetten, double verzadigdeVetten, double koolhydraten, double suikers, double eiwitten, double zouten)
        {
            Invoer invoer = new Invoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);
            InvoerList.Add(invoer);
        }
    }
}