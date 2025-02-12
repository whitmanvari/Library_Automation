using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class BookRepository : IRepository<Book>
    {
        
        public void Add(Book entity)
        {
           
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public List<Book> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
