using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Interfaces;
using GetHealthy.DTO;
using System.Data;
using GetHealthy.Containers;

namespace GetHealthy.DAL
{
    public class UitkomstDAL : IUitkomst
    {
        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        void IUitkomst.storeUitkomst(UitkomstDTO dto)
        {
            connection = new SqlConnection(connetionString);

            string addUitkomst =
                @"INSERT INTO Uitkomst (MaximaleCalorieën, MinimaleCalorieën, 
                                        MaximaleTotaleVetten, MinimaleTotaleVetten, 
                                        MaximaleVerzadigdeVetten, 
                                        MaximaleKoolhydraten, MinimaleKoolhydraten, 
                                        MaximaleSuikers, 
                                        MaximaleEiwitten, MinimaleEiwitten, 
                                        MaximaleZouten, MinimaleZouten)" +
                "VALUES (" +
                        "@dto.maximaleCalorieën, @dto.minimaleCalorieën," +
                        "@dto.maximaleTotaleVetten, @dto.minimaleTotaleVetten," +
                        "@dto.maximaleVerzadigdeVetten," +
                        "@dto.maximaleKoolhydraten, @dto.minimaleKoolhydraten," +
                        "@dto.maximaleSuikers," +
                        "@dto.maximaleEiwitten, @dto.minimaleEiwitten," +
                        "@dto.maximaleZouten, @dto.minimaleZouten)";

            connection.Open();
            cmd = new SqlCommand(addUitkomst, connection);

            cmd.Parameters.AddWithValue("@dto.maximaleCalorieën", dto.maximaleCalorieën);
            cmd.Parameters.AddWithValue("@dto.minimaleCalorieën", dto.minimaleCalorieën);
            cmd.Parameters.AddWithValue("@dto.maximaleTotaleVetten", dto.maximaleTotaleVetten);
            cmd.Parameters.AddWithValue("@dto.minimaleTotaleVetten", dto.minimaleTotaleVetten);
            cmd.Parameters.AddWithValue("@dto.maximaleVerzadigdeVetten", dto.maximaleVerzadigdeVetten);
            cmd.Parameters.AddWithValue("@dto.maximaleKoolhydraten", dto.maximaleKoolhydraten);
            cmd.Parameters.AddWithValue("@dto.minimaleKoolhydraten", dto.minimaleKoolhydraten);
            cmd.Parameters.AddWithValue("@dto.maximaleSuikers", dto.maximaleSuikers);
            cmd.Parameters.AddWithValue("@dto.maximaleEiwitten", dto.maximaleEiwitten);
            cmd.Parameters.AddWithValue("@dto.minimaleEiwitten", dto.minimaleEiwitten);
            cmd.Parameters.AddWithValue("@dto.maximaleZouten", dto.maximaleZouten);
            cmd.Parameters.AddWithValue("@dto.minimaleZouten", dto.minimaleZouten);

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
