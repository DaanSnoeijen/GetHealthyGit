using System;
using System.Collections.Generic;
using GetHealthy.Interfaces;
using GetHealthy.Models;

namespace GetHealthy.Controllers
{
    public class ProductContainer : IProductContainer
    {
        public List<Product> ProductList = new List<Product>();
        public List<Product> SelectedProducts = new List<Product>();

        IProduct iProduct;

        public ProductContainer(IProduct product)
        {
            iProduct = product;
        }

        public ProductContainer()
        {
            IProduct iProduct = new ProductenDAL();
        }

        public void GetProduct()
        {
            ProductList.Clear();

            foreach (ProductDTO item in iProduct.GetProduct())
            {
                Product prod = new Product(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                ProductList.Add(prod);
            }
        }
    }
}
