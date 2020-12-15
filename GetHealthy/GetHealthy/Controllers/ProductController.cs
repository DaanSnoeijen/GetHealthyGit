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
        ProductContainer productContainer;

        public ProductController(ProductContainer product)
        {
            productContainer = product;
        }

        public void ConvertToViewModel()
        {
            productList.Clear();

            foreach (Product item in productContainer.ProductList)
            {
                ProductViewModel product = new ProductViewModel(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                productList.Add(product);
            }
        }
    }
}
