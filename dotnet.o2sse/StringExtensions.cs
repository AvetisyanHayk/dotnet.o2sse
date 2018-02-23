using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2
{
    public static class StringExtensions
    {
        public static int CountChar(this string text, char c)
        {
            int count = 0;
            foreach (char _c in text)
            {
                if (c == _c) count++;
            }
            return count;
        }
    }
}
