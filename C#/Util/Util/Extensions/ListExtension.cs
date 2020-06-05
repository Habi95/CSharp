using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Util.Extensions
{
    public static class ListExtension
    {
        public static string ToConsole<T>(this List<T> list)
        {
            string output = string.Empty;

            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(output))
                {
                    output = $"{output}\n";
                }
                output = output + item.ToString();
            }
            return output;
        }
    }
}
