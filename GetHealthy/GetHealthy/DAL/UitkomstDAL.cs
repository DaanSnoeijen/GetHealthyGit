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

        void IUitkomst.storeUitkomst(
            int maxCal,
            int minCal,
            int maxTot,
            int minTot,
            int maxVer,
            int maxKool,
            int minKool,
            int maxSuik,
            double maxEi,
            double minEi,
            double maxZout,
            double minZout)
        {
            connection = new SqlConnection(connetionString);

            UitkomstDTO dto = new UitkomstDTO(maxCal, minCal, maxTot, minTot, maxVer, maxKool, minKool, maxSuik, maxEi, minEi, maxZout, minZout);

            string addUitkomst =
                @"INSERT INTO Uitkomst (MaximaleCalorieën, MinimaleCalorieën, 
                                        MaximaleTotaleVetten, MinimaleTotaleVetten, 
                                        MaximaleVerzadigdeVetten, 
                                        MaximaleKoolhydraten, MinimaleKoolhydraten, 
                                        MaximaleSuikers, 
                                        MaximaleEiwitten, MinimaleEiwitten, 
                                        MaximaleZouten, MinimaleZouten)" +
                "VALUES (" +
                        "@maxcal, @mincal," +
                        "@maxtot, @mintot," +
                        "@maxver," +
                        "@maxkool, @minkool," +
                        "@maxsuik," +
                        "@maxei, @minei," +
                        "@maxzout, @minzout)";

            connection.Open();
            cmd = new SqlCommand(addUitkomst, connection);

            cmd.Parameters.AddWithValue("@maxcal", dto.maximaleCalorieën);
            cmd.Parameters.AddWithValue("@mincal", dto.minimaleCalorieën);
            cmd.Parameters.AddWithValue("@maxtot", dto.maximaleTotaleVetten);
            cmd.Parameters.AddWithValue("@mintot", dto.minimaleTotaleVetten);
            cmd.Parameters.AddWithValue("@maxver", dto.maximaleVerzadigdeVetten);
            cmd.Parameters.AddWithValue("@maxkool", dto.maximaleKoolhydraten);
            cmd.Parameters.AddWithValue("@minkool", dto.minimaleKoolhydraten);
            cmd.Parameters.AddWithValue("@maxsuik", dto.maximaleSuikers);
            cmd.Parameters.AddWithValue("@maxei", dto.maximaleEiwitten);
            cmd.Parameters.AddWithValue("@minei", dto.minimaleEiwitten);
            cmd.Parameters.AddWithValue("@maxzout", dto.maximaleZouten);
            cmd.Parameters.AddWithValue("@minzout", dto.minimaleZouten);

            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
}
