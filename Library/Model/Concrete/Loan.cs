using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class Loan: IBase
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        //Must be nullable, cause if the user loan the book he might be did not return the book yet.
        public DateTime? ReturnDate { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get;  set; }
    }
}
