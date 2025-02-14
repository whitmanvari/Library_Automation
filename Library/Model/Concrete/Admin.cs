using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Admin : IPerson
    {
        //Admin information.
       
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value < DateTime.Now)
                    _birthDate = value;
            }
        }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
    }
}
