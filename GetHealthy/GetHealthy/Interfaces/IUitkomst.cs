using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Interfaces
{
    interface IUitkomst
    {
        public void storeUitkomst(
            int maxCal,
            int minCal,
            int maxTot,
            int minTot,
            int maxVer,
            int maxKool,
            int minKool,
            int maxSuik,
            double maxEi,
            double minEi,
            double maxZout,
            double minZout);
    }
}
