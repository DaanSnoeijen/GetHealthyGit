using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;

namespace GetHealthy.Containers
{
    public class UitkomstContainer
    {
        public List<Uitkomst> UitkomstList = new List<Uitkomst>();

        public void AddUitkomst()
        {
            Uitkomst uitkomst = new Uitkomst();
            UitkomstList.Add(uitkomst);
        }
    }
}
