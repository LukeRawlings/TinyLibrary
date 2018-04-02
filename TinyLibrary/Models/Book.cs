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
        public Author Author { get; set; }
        public string Location { get; set; }
        public int Count { get; set; }


    }
}
