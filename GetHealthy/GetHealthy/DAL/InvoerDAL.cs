using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GetHealthy.Interfaces;
using GetHealthy.DTO;
using System.Data;

namespace GetHealthy.DAL
{
    public class InvoerDAL : IInvoer
    {
        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        void IInvoer.StoreInvoer()
        {
            connection = new SqlConnection(connetionString);

            InvoerDTO invoerDTO = new InvoerDTO(
                Program.invoerContainer.InvoerList[0].calorieën,
                Program.invoerContainer.InvoerList[0].totaleVetten,
                Program.invoerContainer.InvoerList[0].verzadigdeVetten,
                Program.invoerContainer.InvoerList[0].koolhydraten,
                Program.invoerContainer.InvoerList[0].suikers,
                Program.invoerContainer.InvoerList[0].eiwitten,
                Program.invoerContainer.InvoerList[0].zouten);

            string addInvoer =
                @"INSERT INTO Invoer (InvoerCalorieën, InvoerTotaleVetten, InvoerVerzadigdeVetten, InvoerKoolhydraten, InvoerSuikers, InvoerEiwitten, InvoerZouten, Datum)" +
                "VALUES (@calorieën, @totaleVetten, @verzadigdeVetten, @koolhydraten, @suikers, @eiwitten, @zouten, @today)";

            connection.Open();
            cmd = new SqlCommand(addInvoer, connection);

            cmd.Parameters.AddWithValue("@calorieën", SqlDbType.Float);
            cmd.Parameters["@calorieën"].Value = invoerDTO.calorieën;
            cmd.Parameters.AddWithValue("@totaleVetten", SqlDbType.Float);
            cmd.Parameters["@totaleVetten"].Value = invoerDTO.totaleVetten;
            cmd.Parameters.AddWithValue("@verzadigdeVetten", SqlDbType.Float);
            cmd.Parameters["@verzadigdeVetten"].Value = invoerDTO.verzadigdeVetten;
            cmd.Parameters.AddWithValue("@koolhydraten", SqlDbType.Float);
            cmd.Parameters["@koolhydraten"].Value = invoerDTO.koolhydraten;
            cmd.Parameters.AddWithValue("@suikers", SqlDbType.Float);
            cmd.Parameters["@suikers"].Value = invoerDTO.suikers;
            cmd.Parameters.AddWithValue("@eiwitten", SqlDbType.Float);
            cmd.Parameters["@eiwitten"].Value = invoerDTO.eiwitten;
            cmd.Parameters.AddWithValue("@zouten", SqlDbType.Float);
            cmd.Parameters["@zouten"].Value = invoerDTO.zouten;
            cmd.Parameters.AddWithValue("@today", SqlDbType.DateTime);
            cmd.Parameters["@today"].Value = invoerDTO.today.Date;

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
