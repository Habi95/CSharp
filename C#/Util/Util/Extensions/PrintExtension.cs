using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
   public static class PrintExtension
    {
        /// <summary>
        /// länge
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="eggs"></param>
        /// <returns></returns>
        public static string Print<T>(this object[] eggs)
        {
             string print  = ($"{eggs.Length} eggs");
            return print;
        }
       
    }
}
