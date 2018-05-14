﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx.Controllers.Objecten
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        //public int AuthorId { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }


    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; }
    }
}
