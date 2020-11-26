using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;

namespace GetHealthy.Controllers
{
    public class ProductController
    {
        public List<ProductViewModel> productList = new List<ProductViewModel>();

        public void ConvertToViewModel()
        {
            Program.productContainer.ProductList.Clear();

            foreach (Product item in Program.productContainer.ProductList)
            {
                ProductViewModel product = new ProductViewModel(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                productList.Add(product);
            }
        }
    }
}
