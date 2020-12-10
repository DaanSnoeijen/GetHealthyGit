using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using GetHealthy.Interfaces;
using GetHealthy.DAL;

namespace GetHealthy.Containers
{
    public class UitkomstContainer
    {
        public List<Uitkomst> UitkomstList = new List<Uitkomst>();
        IUitkomst iUitkomst = new UitkomstDAL();

        public void AddUitkomst()
        {
            Uitkomst uitkomst = new Uitkomst();
            UitkomstList.Add(uitkomst);
        }

        public void AddToDatabase()
        {
            iUitkomst.storeUitkomst(
                UitkomstList[0].maximaleCalorieën,
                UitkomstList[0].minimaleCalorieën,
                UitkomstList[0].maximaleTotaleVetten,
                UitkomstList[0].minimaleTotaleVetten,
                UitkomstList[0].maximaleVerzadigdeVetten,
                UitkomstList[0].maximaleKoolhydraten,
                UitkomstList[0].minimaleKoolhydraten,
                UitkomstList[0].maximaleSuikers,
                UitkomstList[0].maximaleEiwitten,
                UitkomstList[0].minimaleEiwitten,
                UitkomstList[0].maximaleZouten,
                UitkomstList[0].minimaleZouten);
        }
    }
}
