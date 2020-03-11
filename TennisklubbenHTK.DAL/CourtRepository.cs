using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisklubbenHTK.Entities;

namespace TennisklubbenHTK.DAL
{
    public class CourtRepository
    {
        public CourtRepository()
        {

        }

        public Court GetCourtFromId(int courtId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                return connection.Query<Court>("dbo.spTennisKlubbenHTK_GetCourtFromId @CourtId", courtId) as Court;
            }
        }

        public List<Court> GetListOfcourts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                return connection.Query<Court>("dbo.spTennisKlubbenHTK_GetListOfCourts").ToList();
            }
        }

        public void CreateNewCourt(Court court)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubbenHTK_CreateNewCourt @Name, @Underlay", court);
            }
        }

        public void UpdateCourt(Court court)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubbenHTK_UpdateCourt @CourtId, @Name, @Underlay", court);
            }
        }

        public void DeleteCourt(int courtId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubben_DeleteCourtBasedOnId @CourtId", new { CourtId = courtId });
            }
        }
    }
}
