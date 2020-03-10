using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisklubbenHTK.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberAddress { get; set; }
        public string MobilNumber { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int RankListPoints { get; set; }
        public bool Active { get; set; }

        /// <summary>
        /// Constructor for Member, this one is used when getting data from the database
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="memberAddress"></param>
        /// <param name="mobilNumber"></param>
        /// <param name="email"></param>
        /// <param name="birthday"></param>
        /// <param name="rankListPoints"></param>
        /// <param name="active"></param>
        public Member(int memberId, string firstName, string lastName, string memberAddress, string mobilNumber, string email, DateTime birthday, int rankListPoints, bool active)
        {
            MemberId = memberId;
            FirstName = firstName;
            LastName = lastName;
            MemberAddress = memberAddress;
            MobilNumber = mobilNumber;
            Email = email;
            Birthday = birthday;
            RankListPoints = rankListPoints;
            Active = active;
        }

        /// <summary>
        /// Constructor for Member, this one is used when creating new members.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="memberAddress"></param>
        /// <param name="mobilNumber"></param>
        /// <param name="email"></param>
        /// <param name="birthday"></param>
        /// <param name="rankListPoints"></param>
        /// <param name="active"></param>
        public Member(string firstName, string lastName, string memberAddress, string mobilNumber, string email, DateTime birthday, int rankListPoints, bool active)
        {            
            FirstName = firstName;
            LastName = lastName;
            MemberAddress = memberAddress;
            MobilNumber = mobilNumber;
            Email = email;
            Birthday = birthday;
            RankListPoints = rankListPoints;
            Active = active;
        }

        public Member()
        {
        }
    }
}
