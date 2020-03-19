using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisklubbenHTK.Entities
{
    public class Court
    {
        public int CourtId { get; set; }
        public string Name { get; set; }
        public string Underlay { get; set; }

        /// <summary>
        /// Constructor for Court this is used when getting data from the database
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="underlay"></param>
        public Court(int courtid, string name, string underlay)
        {
            CourtId = courtid;
            Name = name;
            Underlay = underlay;
        }

        /// <summary>
        /// Constructor for Court this is used when creating a new court
        /// </summary>
        /// <param name="name"></param>
        /// <param name="underlay"></param>
        public Court(string name, string underlay)
        {
            Name = name;
            Underlay = underlay;
        }
    }
}
