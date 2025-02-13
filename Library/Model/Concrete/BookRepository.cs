using Library.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class BookRepository : IRepository<Book>
    {
        private readonly Context _context;
        public BookRepository(Context context)
        {
            _context = context;
        }
        public void Add(Book addBookEntity)
        {
           
        }

        public void Delete(Book deleteBookEntity)
        {
            throw new NotImplementedException();
        }

        public List<Book> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Book updateBookEntity)
        {
            throw new NotImplementedException();
        }
    }
}
