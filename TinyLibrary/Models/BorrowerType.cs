using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    class BorrowerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxCheckout { get; set; }


        public BorrowerType()
        {
            //Id = id;
            //Name = name;
            //MaxCheckout = maxCheckout;
        }
    }
}
