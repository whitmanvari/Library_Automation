﻿using Library.Model.Concrete;
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
            Database.Connection.ConnectionString = "Server=LAPTOP-CF7VKITM;Database=LibraryAutomation;uid=sa;password=1";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Member> members { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Book> books { get; set; }
    }
}
