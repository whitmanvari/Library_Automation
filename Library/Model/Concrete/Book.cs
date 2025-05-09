﻿using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Concrete
{
    public class Book: IBase
    {
        //Book information.
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public int BookPage { get; set; }
        //Book publish year.
        public int BookYear { get; set; }
        public string BookLanguage { get; set; }
        public string BookGenre { get; set; }
        public string BookDescription { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //default active
        public bool IsActive { get; set; } = true; 
    }
}
