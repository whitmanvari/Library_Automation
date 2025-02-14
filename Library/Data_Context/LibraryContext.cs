using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContext
{
    public class LibraryContext: DbContext
    {
        //Mssql connection string will be add.
        public LibraryContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-CF7VKITM;Database=LibraryAutomation;uid=sa;password=1";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<User>().ToTable("Users");


            base.OnModelCreating(modelBuilder);
        }
       
        public DbSet<Role> role { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Book> book { get; set; }
    }
}
