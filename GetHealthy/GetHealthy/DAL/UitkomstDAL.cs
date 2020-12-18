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
                @"INSERT INTO Uitkomst (MaximaleCalorieën, MinimaleCalorieën, MaximaleTotaleVetten, MinimaleTotaleVetten, MaximaleVerzadigdeVetten, MaximaleKoolhydraten, MinimaleKoolhydraten, MaximaleSuikers, MaximaleEiwitten, MinimaleEiwitten, MaximaleZouten, MinimaleZouten)
                  VALUES (@maximaleCalorieën, @minimaleCalorieën, @maximaleTotaleVetten, @minimaleTotaleVetten, @maximaleVerzadigdeVetten, @maximaleKoolhydraten, @minimaleKoolhydraten, @maximaleSuikers, @maximaleEiwitten, @minimaleEiwitten, @maximaleZouten, @minimaleZouten)";

            connection.Open();
            cmd = new SqlCommand(addUitkomst, connection);

            cmd.Parameters.AddWithValue("@maximaleCalorieën", dto.maximaleCalorieën);
            cmd.Parameters.AddWithValue("@minimaleCalorieën", dto.minimaleCalorieën);
            cmd.Parameters.AddWithValue("@maximaleTotaleVetten", dto.maximaleTotaleVetten);
            cmd.Parameters.AddWithValue("@minimaleTotaleVetten", dto.minimaleTotaleVetten);
            cmd.Parameters.AddWithValue("@maximaleVerzadigdeVetten", dto.maximaleVerzadigdeVetten);
            cmd.Parameters.AddWithValue("@maximaleKoolhydraten", dto.maximaleKoolhydraten);
            cmd.Parameters.AddWithValue("@minimaleKoolhydraten", dto.minimaleKoolhydraten);
            cmd.Parameters.AddWithValue("@maximaleSuikers", dto.maximaleSuikers);
            cmd.Parameters.AddWithValue("@maximaleEiwitten", dto.maximaleEiwitten);
            cmd.Parameters.AddWithValue("@minimaleEiwitten", dto.minimaleEiwitten);
            cmd.Parameters.AddWithValue("@maximaleZouten", dto.maximaleZouten);
            cmd.Parameters.AddWithValue("@minimaleZouten", dto.minimaleZouten);

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
