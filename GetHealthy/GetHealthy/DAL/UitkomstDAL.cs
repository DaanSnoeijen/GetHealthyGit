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
        UitkomstContainer uitkomstContainer;

        string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=GetHealthyDB;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;

        public UitkomstDAL(UitkomstContainer uc)
        {
            uitkomstContainer = uc;
        }

        void IUitkomst.storeUitkomst()
        {
            connection = new SqlConnection(connetionString);

            UitkomstDTO dto = new UitkomstDTO(
                uitkomstContainer.UitkomstList[0].maximaleCalorieën,
                uitkomstContainer.UitkomstList[0].minimaleCalorieën,
                uitkomstContainer.UitkomstList[0].maximaleTotaleVetten,
                uitkomstContainer.UitkomstList[0].minimaleTotaleVetten,
                uitkomstContainer.UitkomstList[0].maximaleVerzadigdeVetten,
                uitkomstContainer.UitkomstList[0].maximaleKoolhydraten,
                uitkomstContainer.UitkomstList[0].minimaleKoolhydraten,
                uitkomstContainer.UitkomstList[0].maximaleSuikers,
                uitkomstContainer.UitkomstList[0].maximaleEiwitten,
                uitkomstContainer.UitkomstList[0].minimaleEiwitten,
                uitkomstContainer.UitkomstList[0].maximaleZouten,
                uitkomstContainer.UitkomstList[0].minimaleZouten);

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
