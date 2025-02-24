using Library.DataContext;
using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Context
{
    public static class Initializer
    {
        public static void SeedCategories()
        {
            using (var context = new LibraryContext())
            {
                //Is there any category in the database?
                if (!context.Categories.Any())
                {
                    var categories = new[]
                    {
                    new Category
                    {
                        Id=1,
                        Name= "Science Fiction",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                                        {
                        Id=2,
                        Name= "Romance",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=3,
                        Name= "Literary Fiction",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=4,
                        Name= "Horror",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=5,
                        Name= "Fantasy",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=6,
                        Name= "Mystery",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=7,
                        Name= "Literary Fiction",
                        CreatedDate = DateTime.Now
                    },
                    new Category
                    {
                        Id=8,
                        Name= "Historical Fiction",
                        CreatedDate = DateTime.Now
                    },
                     new Category
                    {
                        Id=9,
                        Name= "Poetry",
                        CreatedDate = DateTime.Now
                    },
                     new Category
                    {
                        Id=10,
                        Name= "Adventure",
                        CreatedDate = DateTime.Now
                    },
                     new Category
                     {
                         Id=11,
                         Name= "Philosophy",
                         CreatedDate = DateTime.Now
                         },
                     new Category
                     {
                         Id= 12,
                          Name= "Fairy Tale",
                          CreatedDate= DateTime.Now
                     },
                     new Category
                     {
                            Id=13,
                            Name="Dystopian",
                            CreatedDate= DateTime.Now
                     },
                     new Category
                     {
                         Id=14,
                         Name="Biography",
                         CreatedDate= DateTime.Now
                     }
                };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                }
            }
        }
    }
}
