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
        List<Uitkomst> uitkomstList = new List<Uitkomst>();

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
            uitkomstList.Clear();
            uitkomstList.Add(uitkomst);
        }

        public void AddToDatabase()
        {
            UitkomstDTO dto = new UitkomstDTO(
                uitkomstList[0].maximaleCalorieën,
                uitkomstList[0].minimaleCalorieën,
                uitkomstList[0].maximaleTotaleVetten,
                uitkomstList[0].minimaleTotaleVetten,
                uitkomstList[0].maximaleVerzadigdeVetten,
                uitkomstList[0].maximaleKoolhydraten,
                uitkomstList[0].minimaleKoolhydraten,
                uitkomstList[0].maximaleSuikers,
                uitkomstList[0].maximaleEiwitten,
                uitkomstList[0].minimaleEiwitten,
                uitkomstList[0].maximaleZouten,
                uitkomstList[0].minimaleZouten);
            uitkomst.storeUitkomst(dto);
        }

        public Uitkomst GetUitkomst()
        {
            return uitkomstList[0];
        }

        public List<Uitkomst> UitkomstList()
        {
            return uitkomstList;
        }
    }
}
