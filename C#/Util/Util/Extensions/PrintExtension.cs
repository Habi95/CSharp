using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
   public static class PrintExtension
    {
        public static string Print<T>(this object[] eggs)
        {
             string print  = ($"{eggs.Length} eggs");
            return print;
        }
       
    }
}
