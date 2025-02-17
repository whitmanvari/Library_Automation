using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Abstract
{
    public abstract class Person : IBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        DateTime? BirthDate { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Phone { get; set; }
        string Address { get; set; }

    }
}
