using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using GetHealthy.Interfaces;
using GetHealthy.DAL;
using GetHealthy.DTO;

namespace GetHealthy.Containers
{
    public class UitkomstContainer : IUitkomstContainer
    {
        public List<Uitkomst> UitkomstList = new List<Uitkomst>();

        IUitkomst uitkomst;

        public UitkomstContainer(IUitkomst iUitkomst)
        {
            uitkomst = iUitkomst;
        }

        public UitkomstContainer()
        {
            uitkomst = new UitkomstDAL();
        }

        public void AddUitkomst()
        {
            Uitkomst uitkomst = new Uitkomst();
            UitkomstList.Clear();
            UitkomstList.Add(uitkomst);
        }

        public void AddToDatabase()
        {
            UitkomstDTO dto = new UitkomstDTO(
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
            uitkomst.storeUitkomst(dto);
        }
    }
}
