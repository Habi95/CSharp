using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
    public static class StringExtension
    {
     /// <summary>
     /// string parse to personel type
     /// </summary>
     /// <typeparam name="T"></typeparam>
     /// <param name="input"></param>
     /// <returns></returns>
       public static T? ConvertType<T>(this string input) where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(input, typeof(T)); 
            }   
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return null;
        }
    }
    
}
