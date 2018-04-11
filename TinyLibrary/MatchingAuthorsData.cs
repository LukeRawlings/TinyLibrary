using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyLibrary.Models;

namespace TinyLibrary
{
    public class MatchingAuthorsData
    {
        public AddNewBookForm AddNewBookForm { get; set; }
        public Author InputtedAuthor { get; set; } 
        public Book Book { get; set; }
        public IEnumerable<Author> PossibleMatches { get; set; }



    }
}
