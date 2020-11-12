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
            return View();
        }

        public ActionResult ShowProducts()
        {
            DAL dal = new DAL();
            ProductContainer producten = new ProductContainer();
            
            foreach(ProductDTO item in dal.GetProduct())
            {
                Product prod = new Product(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                producten.ProductList.Add(prod);
            }

            return View("InvullenVoeding", producten);
        }
    }
}
