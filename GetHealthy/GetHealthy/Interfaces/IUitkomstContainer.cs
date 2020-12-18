using GetHealthy.DTO;
using GetHealthy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Interfaces
{
    public interface IUitkomstContainer
    {
        void AddUitkomst();
        void AddToDatabase();
    }
}
