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
        public DateTime BirthDate 
        { 
            get => BirthDate;
            set
            {
                if (BirthDate < DateTime.Now)
                {
                    throw new ArgumentException("Birth date cannot be in the future!");
                }
            }
        }
        public abstract string Email { get; set; }
        public abstract string Password { get; set; }
        public abstract string Phone { get; set; }
        public abstract string Address { get; set; }
    }
}
