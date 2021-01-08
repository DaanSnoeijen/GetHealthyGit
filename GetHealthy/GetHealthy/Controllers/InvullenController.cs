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
            Program.productController.ConvertToViewModel();

            InvullenVoedingViewModel invullenVoedingViewModel = new InvullenVoedingViewModel();
            invullenVoedingViewModel.listA = Program.productController.productList;
            invullenVoedingViewModel.ListB = Program.productContainer.SelectedProducts;

            return View("InvullenVoeding", invullenVoedingViewModel);
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

            InvullenVoedingViewModel invullenVoedingViewModel = new InvullenVoedingViewModel();

            foreach (ProductViewModel product in productList)
            {
                if (product.naam == productChecked)
                {
                    Product selectedProduct = new Product(product.naam, product.calorieën, product.totaleVetten, product.verzadigdeVetten, product.koolhydraten, product.suikers, product.eiwitten, product.zouten);

                    double hoeveelheid = double.Parse(hoeveelheidProduct);
                    double hoeveelheidVermenigvuldig;

                    if (hoeveelheid == 1)
                    {
                        hoeveelheidVermenigvuldig = 5;

                        selectedProduct.calorieën *= hoeveelheidVermenigvuldig;
                        selectedProduct.totaleVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.verzadigdeVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.koolhydraten *= hoeveelheidVermenigvuldig;
                        selectedProduct.suikers *= hoeveelheidVermenigvuldig;
                        selectedProduct.eiwitten *= hoeveelheidVermenigvuldig;
                        selectedProduct.zouten *= hoeveelheidVermenigvuldig;
                    }
                    else if (hoeveelheid == 2)
                    {
                        hoeveelheidVermenigvuldig = 2.5;

                        selectedProduct.calorieën *= hoeveelheidVermenigvuldig;
                        selectedProduct.totaleVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.verzadigdeVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.koolhydraten *= hoeveelheidVermenigvuldig;
                        selectedProduct.suikers *= hoeveelheidVermenigvuldig;
                        selectedProduct.eiwitten *= hoeveelheidVermenigvuldig;
                        selectedProduct.zouten *= hoeveelheidVermenigvuldig;
                    }
                    else if (hoeveelheid == 4)
                    {
                        hoeveelheidVermenigvuldig = 0.5;

                        selectedProduct.calorieën *= hoeveelheidVermenigvuldig;
                        selectedProduct.totaleVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.verzadigdeVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.koolhydraten *= hoeveelheidVermenigvuldig;
                        selectedProduct.suikers *= hoeveelheidVermenigvuldig;
                        selectedProduct.eiwitten *= hoeveelheidVermenigvuldig;
                        selectedProduct.zouten *= hoeveelheidVermenigvuldig;
                    }
                    else if (hoeveelheid == 5)
                    {
                        hoeveelheidVermenigvuldig = 0.1;

                        selectedProduct.calorieën *= hoeveelheidVermenigvuldig;
                        selectedProduct.totaleVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.verzadigdeVetten *= hoeveelheidVermenigvuldig;
                        selectedProduct.koolhydraten *= hoeveelheidVermenigvuldig;
                        selectedProduct.suikers *= hoeveelheidVermenigvuldig;
                        selectedProduct.eiwitten *= hoeveelheidVermenigvuldig;
                        selectedProduct.zouten *= hoeveelheidVermenigvuldig;
                    }

                    Program.productContainer.SelectedProducts.Add(selectedProduct);
                    invullenVoedingViewModel.listA = productList;
                }
            }

            if (invullenVoedingViewModel.Page < 1 || invullenVoedingViewModel.Page > 10)
            {
                invullenVoedingViewModel.Page = 1;
            }

            if (Convert.ToString(HttpContext.Request.Form["ProductSearch"]) != "")
            {
                string productSearch = HttpContext.Request.Form["ProductSearch"];
                List<ProductViewModel> productSearchList = new List<ProductViewModel>();

                foreach (Product product in Program.productContainer.ProductList)
                {
                    if (product.naam == productSearch)
                    {
                        ProductViewModel productVM = new ProductViewModel(
                            product.naam,
                            product.calorieën,
                            product.totaleVetten,
                            product.verzadigdeVetten,
                            product.koolhydraten,
                            product.suikers,
                            product.eiwitten,
                            product.zouten);
                        productSearchList.Add(productVM);

                        invullenVoedingViewModel.listA = productSearchList;
                    }
                }

                invullenVoedingViewModel.Page = 0;
            }
            else if (Convert.ToString(HttpContext.Request.Form["Pagina"]) != "")
            {
                invullenVoedingViewModel.Page = Convert.ToInt32(HttpContext.Request.Form["Pagina"]);
                invullenVoedingViewModel.listA = productList;
            }
            else
            {
                invullenVoedingViewModel.listA = productList;
            }
            invullenVoedingViewModel.ListB = Program.productContainer.SelectedProducts;

            return View("InvullenVoeding", invullenVoedingViewModel);
        }
    }
}
