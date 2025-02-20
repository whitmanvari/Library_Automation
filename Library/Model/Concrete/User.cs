using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class User: Person
    {
        public DateTime? BirthDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
