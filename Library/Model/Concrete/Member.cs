﻿using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class Member : Person
    {
        public Member()
        {
            MembershipDate = DateTime.Now;
        }
        //Member information.
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string Email { get; set; }
        public override string Password { get; set; }
        public override string Phone { get; set; }
        public override string Address { get; set; }
        //Member registration date will be set to the current date.
        public DateTime MembershipDate { get; set; }
    }
}
