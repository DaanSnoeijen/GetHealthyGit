using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetHealthy.Controllers
{
    public class InvullenController : Controller
    {
        public IActionResult InvullenPersoonlijk()
        {
            return View();
        }

        public IActionResult InvullenVoeding()
        {
            Program.productContainer.GetProduct();

            List<ProductViewModel> productList = new List<ProductViewModel>();

            foreach (Product item in Program.productContainer.ProductList)
            {
                ProductViewModel product = new ProductViewModel(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                productList.Add(product);
            }

            return View("InvullenVoeding", productList);
        }
    }
}
