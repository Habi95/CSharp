using System;
using System.Collections.Generic;
using System.Text;

namespace PersonFileReader.model
{
    class Person
    {
        /// <summary>
    /// firstname
    /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// current age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// hometown
        /// </summary>
        public string LivingPlace { get; set; }
        /// <summary>
        /// Job of Person
        /// </summary>
        public string Job { get; set; }
    }
}
