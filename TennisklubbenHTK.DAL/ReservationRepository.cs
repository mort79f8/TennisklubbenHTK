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
    class ReservationRepository
    {
        public ReservationRepository()
        {

        }

        public List<Reservation> GetAllReservations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                return connection.Query<Reservation>("SELECT * FROM Reservation INNER JOIN Court ON Reservation.Court = Court.CourtId").ToList();
            }
        }
    }
}
