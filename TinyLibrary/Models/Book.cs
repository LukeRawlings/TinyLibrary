﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<Author> BookAuthors { get; set; } = new List<Author>();
        public string Location { get; set; }
        public int Count { get; set; }
        public int NumAvailable { get; set; }
        public int Year { get; set; }
    }
}
