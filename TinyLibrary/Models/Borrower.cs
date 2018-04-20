using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BorrowerType { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public override string ToString()
        {
            string str = "";
            str += Id + " - " + FirstName + " " + LastName + " - " + BorrowerType + ": ";
            foreach(Book b in BorrowedBooks)
            {
                str += b + " ";
            };

            return str;
        }
    }
}
