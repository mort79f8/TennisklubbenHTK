using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisklubbenHTK.DAL;
using TennisklubbenHTK.Entities;

namespace TennisklubbenHTK.BIZ
{
    public class Biz
    {
        MemberRepository memberRepository;
        public Biz()
        {
            memberRepository = new MemberRepository();
        }

        public List<Member> GetListOfMembers()
        {
            return memberRepository.GetAllMembers();
        }

        public void CreateNewMember(string firstName, string lastName, string address, string mobilNumber, string email, DateTime birthday )
        {
            Member member = new Member() { FirstName = firstName, LastName = lastName, MemberAddress = address, MobilNumber = mobilNumber, Email = email, Birthday = birthday };

        }
    }
}
