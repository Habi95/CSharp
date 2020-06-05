using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore.model
{
    public static class ConsoleExt
    {
        public static int ReadInt(this string input)
        {
            int number = 0;
            int.TryParse(input, out number);
            return number;
        }
        public static decimal ReadDecimal(this string input)
        {
            decimal number = 0;
            decimal.TryParse(input, out number);
            return number;
        }
    }
}
