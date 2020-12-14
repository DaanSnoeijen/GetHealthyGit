using GetHealthy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Interfaces
{
    public interface IUitkomst
    {
        public void storeUitkomst(UitkomstDTO dto);
    }
}
