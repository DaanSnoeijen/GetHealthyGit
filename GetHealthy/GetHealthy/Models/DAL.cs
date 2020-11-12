using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GetHealthy.Models
{
    public class DAL
    {
        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader rdr;

        public List<ProductDTO> GetProduct()
        {
            connection = new SqlConnection(connetionString);

            string readProduct = "SELECT Naam, Calorieën, TotaleVetten, VerzadigdeVetten, Koolhydraten, Suikers, Eiwitten, Zouten FROM Product";

            connection.Open();
            cmd = new SqlCommand(readProduct, connection);
            rdr = cmd.ExecuteReader();

            List<ProductDTO> producten = new List<ProductDTO>();

            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i += 8)
                {
                    string naam = rdr[i].ToString();
                    double calorieën = rdr.GetDouble(i + 1);
                    double totaleVetten = rdr.GetDouble(i + 2);
                    double verzadigdeVetten = rdr.GetDouble(i + 3);
                    double koolhydraten = rdr.GetDouble(i + 4);
                    double suikers = rdr.GetDouble(i + 5);
                    double eiwitten = rdr.GetDouble(i + 6);
                    double zouten = rdr.GetDouble(i + 7);
                    ProductDTO product = new ProductDTO(naam, calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);
                    producten.Add(product);
                }
            }
            connection.Close();
            rdr.Close();
            cmd.Dispose();
            return producten;

        }
    }
}
