using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Abstract
{
    public abstract class Person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string Email { get; set; }
        public abstract DateTime BirthDate { get; set; }
        public abstract string Password { get; set; }
        public abstract string Phone { get; set; }
        public abstract string Address { get; set; }
    }
}
