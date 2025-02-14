using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class Category : IBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
