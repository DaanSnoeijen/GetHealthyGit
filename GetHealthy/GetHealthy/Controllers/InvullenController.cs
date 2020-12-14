﻿using System;
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
        ProductController productController = new ProductController();

        public IActionResult InvullenPersoonlijk()
        {
            return View();
        }

        public IActionResult InvullenVoedingPagina()
        {
            productController.productContainer.GetProduct();
            productController.ConvertToViewModel();

            InvullenVoedingViewModel invullenVoedingViewModel = new InvullenVoedingViewModel();
            invullenVoedingViewModel.ListA = productController.productList;
            invullenVoedingViewModel.ListB = productController.productContainer.SelectedProducts;

            return View("InvullenVoeding", invullenVoedingViewModel);
        }

        public IActionResult InvullenVoeding()
        {
            productController.productContainer.GetProduct();

            List<ProductViewModel> productList = new List<ProductViewModel>();

            foreach (Product item in productController.productContainer.ProductList)
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

                    productController.productContainer.SelectedProducts.Add(selectedProduct);
                }
            }

            InvullenVoedingViewModel invullenVoedingViewModel = new InvullenVoedingViewModel();
            invullenVoedingViewModel.ListA = productList;
            invullenVoedingViewModel.ListB = productController.productContainer.SelectedProducts;

            return View("InvullenVoeding", invullenVoedingViewModel);
        }
    }
}
