using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    public static class NumberExtensions
    {
        public static bool isOdd(this int number)
        {
            return number % 2 == 1;
        }

        public static bool isEven(this int number)
        {
            return !isOdd(number);
        }
    }
}
