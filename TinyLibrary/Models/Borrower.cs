using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    class Borrower
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BorrowerType { get; set; }

        public override string ToString()
        {
            return Id + " - " + FirstName + " " + LastName + " - " + BorrowerType;
        }
    }
}
