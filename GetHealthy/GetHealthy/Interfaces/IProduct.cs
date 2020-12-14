using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.Models
{
    public interface IProduct
    {
        public List<ProductDTO> GetProduct();
    }
}
