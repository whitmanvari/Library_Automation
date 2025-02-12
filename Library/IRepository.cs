using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IRepository<T>
    {
        //Basic CRUD operations.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Get(T entity);
    }
}
