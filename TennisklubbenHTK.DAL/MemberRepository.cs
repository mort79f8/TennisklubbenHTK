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
    public class MemberRepository
    {
        public MemberRepository()
        {

        }

        public List<Member> GetAllMembers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                return connection.Query<Member>("dbo.spTennisKlubbenHTK_GetListOfMembers").ToList();
            }
        }

        public List<Member> GetAllActiveMembers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                return connection.Query<Member>("dbo.spTennisKlubbenHTK_GetAllActiveMembers").ToList();
            }
        }

        public void CreateNewMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubbenHTKDB_CreateNewMember @FirstName, @LastName, @MemberAddress, @MobilNumber, @Email, @Birthday, @RankListPoints, @Active", member);
            }
        }

        public void UpdateMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubbenHTK_UpdateMember @MemberId @FirstName, @LastName, @MemberAddress, @MobilNumber, @Email, @Birthday, @RankListPoints, @Active", member);
            }
        }

        public void TurnMemberInActive(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisklubbenHTKDB")))
            {
                connection.Execute("dbo.spTennisKlubbenHTK_TurnMemberInActive @MemberId @FirstName, @LastName, @MemberAddress, @MobilNumber, @Email, @Birthday, @RankListPoints, @Active", member);
            }
        }
    }
}
