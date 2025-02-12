using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContext
{
    public class DataContext: DbContext
    {
        //Mssql connection string will be add.
        public DataContext()
        {
            Database.Connection.ConnectionString = "";
        }
    }
}
