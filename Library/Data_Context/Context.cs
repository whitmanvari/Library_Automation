using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContext
{
    public class Context: DbContext
    {
        //Mssql connection string will be add.
        public Context()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-CF7VKITM;Database=LibraryAutomation;uid=sa;password=1";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Book>().ToTable("Book");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Member> member { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Book> book { get; set; }
    }
}
