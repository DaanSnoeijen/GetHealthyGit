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
        IUitkomst iUitkomst = Program.uitkomstDAL;

        public void AddUitkomst()
        {
            Uitkomst uitkomst = new Uitkomst();
            UitkomstList.Add(uitkomst);
        }

        public void AddToDatabase()
        {
            iUitkomst.storeUitkomst();
        }
    }
}
