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
        CourtRepository courtRepository;
        ReservationRepository reservationRepository;

        public Biz()
        {
            memberRepository = new MemberRepository();
            courtRepository = new CourtRepository();
            reservationRepository = new ReservationRepository();
        }

        #region Members methods
        public List<Member> GetListOfMembers()
        {
            return memberRepository.GetAllMembers();
        }

        public List<Member> GetAllActiveMembers()
        {
            return memberRepository.GetAllActiveMembers();
        }

        public void UpdateMember(Member member)
        {
            memberRepository.UpdateMember(member);
        }

        public void CreateNewMember(string firstName, string lastName, string address, string mobilNumber, string email, DateTime birthday )
        {
            Member member = new Member() { FirstName = firstName, LastName = lastName, MemberAddress = address, MobilNumber = mobilNumber, Email = email, Birthday = birthday, RankListPoints = 0, Active = true };
            memberRepository.CreateNewMember(member);
        }
        #endregion

        #region Court methods
        public List<Court> GetListOfCourts()
        {
            return courtRepository.GetListOfcourts();
        }

        public Court GetCourtFromId(int courtId)
        {
            return courtRepository.GetCourtFromId(courtId);
        }

        public void UpdateCourt(Court court)
        {
            courtRepository.UpdateCourt(court);
        }

        public void DeleteCourt(int courtId)
        {
            courtRepository.DeleteCourt(courtId);
        }

        public void CreateNewCourt(string name, string underlay)
        {
            Court court = new Court(name, underlay);
            courtRepository.CreateNewCourt(court);
        }

        #endregion

        #region Reservations methods
        public List<Reservation> GetListOfReservations()
        {
            return reservationRepository.GetAllReservations();
        }
        #endregion
    }
}
