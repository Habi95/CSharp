using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
    class ObjectExtensions
    {
        public static T GenerateObject<T>(object[] param)
        {
            return (T)Activator.CreateInstance(typeof(T), param);
        }

        public static T NewObject<T>() where T : new()
        {
            return new T();
        }

    }
}
