﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisklubbenHTK.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public int Court { get; set; }
        public int MemberOne { get; set; }        


    }
}
