using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using GetHealthy.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GetHealthy.Controllers
{
    public class InvullenController : Controller
    {
        public IActionResult InvullenPersoonlijk()
        {
            return View();
        }

        public IActionResult InvullenVoedingPagina()
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

        public IActionResult InvullenVoeding()
        {
            Program.productContainer.GetProduct();

            List<ProductViewModel> productList = new List<ProductViewModel>();

            foreach (Product item in Program.productContainer.ProductList)
            {
                ProductViewModel product = new ProductViewModel(item.naam, item.calorieën, item.totaleVetten, item.verzadigdeVetten, item.koolhydraten, item.suikers, item.eiwitten, item.zouten);
                productList.Add(product);
            }

            string productChecked = HttpContext.Request.Form["Product"];
            string hoeveelheidProduct = HttpContext.Request.Form["Hoeveelheid"];

            foreach (ProductViewModel product in productList)
            {
                if (product.naam == productChecked)
                {
                    Product selectedProduct = new Product(product.naam, product.calorieën, product.totaleVetten, product.verzadigdeVetten, product.koolhydraten, product.suikers, product.eiwitten, product.zouten);
                    selectedProduct.hoeveelheid = double.Parse(hoeveelheidProduct);
                    Program.productContainer.ProductList.Add(selectedProduct);
                }
            }

            InvullenVoedingViewModel invullenVoedingViewModel = new InvullenVoedingViewModel();
            invullenVoedingViewModel.ListA = productList;
            invullenVoedingViewModel.ListB = Program.productContainer.ProductList;

            return View("InvullenVoeding", invullenVoedingViewModel);
        }
    }
}
