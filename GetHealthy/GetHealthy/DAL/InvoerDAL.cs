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
        InvoerContainer invoerContainer;

        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        public InvoerDAL(InvoerContainer ic)
        {
            invoerContainer = ic;
        }

        void IInvoer.StoreInvoer()
        {
            connection = new SqlConnection(connetionString);

            InvoerDTO dto = new InvoerDTO(
                invoerContainer.InvoerList[0].calorieën,
                invoerContainer.InvoerList[0].totaleVetten,
                invoerContainer.InvoerList[0].verzadigdeVetten,
                invoerContainer.InvoerList[0].koolhydraten,
                invoerContainer.InvoerList[0].suikers,
                invoerContainer.InvoerList[0].eiwitten,
                invoerContainer.InvoerList[0].zouten);

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
