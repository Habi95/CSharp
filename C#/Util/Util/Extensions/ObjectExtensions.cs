using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Extensions
{
   public static class ObjectExtensions
    {
        /// <summary>
        /// Generate Objeect with Parameter {= Generateobject<T>(new object[] { ... } }
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T GenerateObject<T>(object[] param)
        {
            return (T)Activator.CreateInstance(typeof(T), param);
        }
        /// <summary>
        /// Generate Object without Parameter {.NewObject<T>();}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T NewObject<T>() where T : new()
        {
            return new T();
        }

    }
}
