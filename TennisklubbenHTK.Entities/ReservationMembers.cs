using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisklubbenHTK.Entities
{
    public class ReservationMembers
    {
        public int ReservationMembersId { get; set; }
        public Reservation Reservation { get; set; }
        public List<Member> Members { get; set; }        
    }
}
