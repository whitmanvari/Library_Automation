using Library.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class BookRepository : IRepository<Book>
    {
        public void Add(Book addBookEntity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Books.Add(addBookEntity);
                context.SaveChanges();
            }
        }
        public void Delete(Book deleteBookEntity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Entry(deleteBookEntity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Book> Get()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Books.Include(b => b.Category).ToList();
            }
        }
        public void Update(Book updateBookEntity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Entry(updateBookEntity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
