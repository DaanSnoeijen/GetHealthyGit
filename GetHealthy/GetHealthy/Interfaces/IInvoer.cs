using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Containers;
using GetHealthy.DTO;

namespace GetHealthy.Interfaces
{
    public interface IInvoer
    {
        public void StoreInvoer(InvoerDTO invoerDTO);
    }
}
