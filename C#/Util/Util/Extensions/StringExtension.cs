using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
    public static class StringExtension
    {
     
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
