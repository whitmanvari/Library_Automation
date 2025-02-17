using Library.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(User entity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<User> Get()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Users.Include(u => u.Role).ToList();
            }
        }
        public void Update(User entity)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
