using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetHealthy.Controllers
{
    public class RandomProductenTmp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        ProductContainer productContainer = new ProductContainer();

        [RouteAttribute("/RandomProductenTmp/ProductenToevoegen")]
        public void ProductenToevoegen()
        {
            for (int i = 0; i < 1000; i++)
            {
                ProductDTO dto = new ProductDTO(
                    productContainer.ProductList[i].naam,
                    productContainer.ProductList[i].calorieën,
                    productContainer.ProductList[i].totaleVetten,
                    productContainer.ProductList[i].verzadigdeVetten,
                    productContainer.ProductList[i].koolhydraten,
                    productContainer.ProductList[i].suikers,
                    productContainer.ProductList[i].eiwitten,
                    productContainer.ProductList[i].zouten);

                string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand cmd;

                string addProduct = @"INSERT INTO dbo.Product (Naam, Calorieën, TotaleVetten, VerzadigdeVetten, Koolhydraten, Suikers, Eiwitten, Zouten, Hoeveelheid)
                                        VALUES (@f1, @f2, @f3, @f4, @f5, @f6, @f7, @f8, @f9);";

                connection.Open();
                cmd = new SqlCommand(addProduct, connection);

                cmd.Parameters.Add("@f1", System.Data.SqlDbType.NText).Value = dto.naam;
                cmd.Parameters.Add("@f2", System.Data.SqlDbType.Float).Value = dto.calorieën;
                cmd.Parameters.Add("@f3", System.Data.SqlDbType.Float).Value = dto.totaleVetten;
                cmd.Parameters.Add("@f4", System.Data.SqlDbType.Float).Value = dto.verzadigdeVetten;
                cmd.Parameters.Add("@f5", System.Data.SqlDbType.Float).Value = dto.koolhydraten;
                cmd.Parameters.Add("@f6", System.Data.SqlDbType.Float).Value = dto.suikers;
                cmd.Parameters.Add("@f7", System.Data.SqlDbType.Float).Value = dto.eiwitten;
                cmd.Parameters.Add("@f8", System.Data.SqlDbType.Float).Value = dto.zouten;
                cmd.Parameters.Add("@f9", System.Data.SqlDbType.Float).Value = dto.hoeveelheid;

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
