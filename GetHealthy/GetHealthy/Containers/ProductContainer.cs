using System;
using System.Collections.Generic;
using GetHealthy.Models;

namespace GetHealthy.Controllers
{
    public class ProductContainer
    {
        public List<Product> ProductList = new List<Product>();
        public List<Product> SelectedProducts = new List<Product>();

        public void GetProduct()
        {
            DAL dal = new DAL();

            ProductList.Clear();

            foreach (ProductDTO item in dal.GetProduct())
            {
                Product prod = new Product(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                ProductList.Add(prod);
            }
        }
    }
}
