using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User : Person
    {
        //User information.
        public string Role { get; set; }
        public override string Password { get; set; }
        public override string Phone { get; set; }
        public override string Address { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string Email { get; set; }

    }
}
