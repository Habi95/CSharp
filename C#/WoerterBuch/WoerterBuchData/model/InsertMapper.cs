using System;
using System.Collections.Generic;
using System.Text;

namespace WoerterBuchData
{
    public class InsertMapper
    {
        /// <summary>
        /// From
        /// </summary>
        public string Table { get; set; }
        /// <summary>
        /// Column name & Value
        /// </summary>
        public Dictionary<string, string> ColumnValueDict { get; set; } = new Dictionary<string, string>();
    }
}
