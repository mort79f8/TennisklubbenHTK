using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TennisklubbenHTK.DAL;
using TennisklubbenHTK.Entities;

namespace ConsoleForTestingReposity
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                //    string sql = @"select pe.*, ph.* 
                //                   from dbo.Person pe
                //                   left join dbo.Phone ph
                //                     on pe.CellPhoneId = ph.Id;";

                string sql = @"SELECT r.*, c.*
                               FROM dbo.Reservation r
                               LEFT JOIN dbo.Court c
                               ON r.Court = c.CourtId";

                var reservations = connection.Query<Reservation, Court, Reservation>(sql,
                    (reservation, court) => { reservation.Court = court.CourtId; return reservation; }, splitOn: "CourtId");

                foreach (var r in reservations)
                {
                    //Console.WriteLine($"{ r.Id } { r.Time } { r.MemberOne } { r.Court.Name } {r.Court.Underlay }");
                }
            }

        }
    }
}
