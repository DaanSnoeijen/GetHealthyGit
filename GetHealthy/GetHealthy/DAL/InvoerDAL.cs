using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GetHealthy.Interfaces;
using GetHealthy.DTO;
using System.Data;
using GetHealthy.Containers;

namespace GetHealthy.DAL
{
    public class InvoerDAL : IInvoer
    {
        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        void IInvoer.StoreInvoer(InvoerDTO dto)
        {
            connection = new SqlConnection(connetionString);

            string addInvoer =
                @"INSERT INTO Invoer (InvoerCalorieën, InvoerTotaleVetten, InvoerVerzadigdeVetten, InvoerKoolhydraten, InvoerSuikers, InvoerEiwitten, InvoerZouten, Datum)" +
                "VALUES (@calorieën, @totaleVetten, @verzadigdeVetten, @koolhydraten, @suikers, @eiwitten, @zouten, @today)";

            connection.Open();
            cmd = new SqlCommand(addInvoer, connection);

            cmd.Parameters.AddWithValue("@calorieën", dto.calorieën);
            cmd.Parameters.AddWithValue("@totaleVetten", dto.totaleVetten);
            cmd.Parameters.AddWithValue("@verzadigdeVetten", dto.verzadigdeVetten);
            cmd.Parameters.AddWithValue("@koolhydraten", dto.koolhydraten);
            cmd.Parameters.AddWithValue("@suikers", dto.suikers);
            cmd.Parameters.AddWithValue("@eiwitten", dto.eiwitten);
            cmd.Parameters.AddWithValue("@zouten", dto.zouten);
            cmd.Parameters.AddWithValue("@today", dto.today.Date);

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
