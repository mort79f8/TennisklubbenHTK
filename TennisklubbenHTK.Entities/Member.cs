using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisklubbenHTK.Entities
{
    public class Member
    {
        private string firstname;

        public int MemberId { get; set; }
        public string FirstName 
        {
            get => firstname;
            set
            {
                var validationResult = FirstnameValidation(value);
                if (!validationResult.isValid)
                {
                    throw new ArgumentException(validationResult.errorMessage, nameof(FirstName));
                }
                else
                {
                    if (value != firstname)
                    {
                        firstname = value;
                    }
                }
            }
        }

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

        public static (bool isValid, string errorMessage) FirstnameValidation(string firstname)
        {
            if (firstname.Length > 15)
            {
                return (false, "Fornavnet er for langt, må ikke være mere end 15 bogstaver langt");
            }
            if (firstname.Any(char.IsDigit))
            {
                return (false, "Fornavnet må ikke indeholde tal");
            }
            if (firstname.Length < 2)
            {
                return (false, "Fornavnet skal være på mere end 1 bogstav");
            }

            return (true, String.Empty);
        }
    }
}
