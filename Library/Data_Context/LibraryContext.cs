﻿using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContext
{
    public class LibraryContext : DbContext
    {
        //Mssql connection string will be add.
        public LibraryContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-CF7VKITM;Database=LibraryAutomation;uid=sa;password=1";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.User) //Specifies that each 'Loan' record must be linked to a 'User'.
                .WithMany()
                .HasForeignKey(l => l.UserId) //UserId in the Loan table is used as the foreign key of the User entity.
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.Book)
                .WithMany()
                .HasForeignKey(l => l.BookId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
