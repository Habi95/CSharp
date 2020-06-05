using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto.model
{
    public static class ConsoleExt
    {
        public static int ReadInt(this string input)
        {
            int number = 0;
            int.TryParse(input, out number);
            return number;
        }
    }
}
