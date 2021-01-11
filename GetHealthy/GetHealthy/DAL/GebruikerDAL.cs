using GetHealthy.DTO;
using GetHealthy.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GetHealthy.DAL
{
    public class GebruikerDAL : IGebruiker
    {
        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        public void StoreGebruiker(GebruikerDTO dto)
        {
            connection = new SqlConnection(connetionString);

            string addInvoer =
                @"INSERT INTO Gebruiker (Geslacht, Gewicht, GeboorteDatum, Lengte, SportPerWeek, Werk, Veganist)" +
                "VALUES (@Geslacht, @Gewicht, @GeboorteDatum, @Lengte, @SportPerWeek, @Werk, @Veganist)";

            connection.Open();
            cmd = new SqlCommand(addInvoer, connection);

            cmd.Parameters.AddWithValue("@Geslacht", dto.geslacht);
            cmd.Parameters.AddWithValue("@Gewicht", dto.gewicht);
            cmd.Parameters.AddWithValue("@GeboorteDatum", dto.geboortedatum);
            cmd.Parameters.AddWithValue("@Lengte", dto.lengte);
            cmd.Parameters.AddWithValue("@SportPerWeek", dto.sportPerWeek);
            cmd.Parameters.AddWithValue("@Werk", dto.werk);
            cmd.Parameters.AddWithValue("@Veganist", dto.vegan);

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
