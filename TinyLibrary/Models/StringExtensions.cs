using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    public static class StringExtensions
    {
        public static bool NotEmpty(this string source)
        {
            return source.Length > 0;
        }
    }
}
