using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public static class IntExtentions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}