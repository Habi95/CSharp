using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class App
    {
        public string Name { get; set; }
        public AppTypEnum Typ { get; set; }
        public string Publisher { get; set; }


        public App(string name, AppTypEnum typ, string publisher)
        {
            Name = name;
            Typ = typ;
            Publisher = publisher;

        }

        public override string ToString()
        {
           return $"Name der App [ {Name} ] \nTyp der App [ {Typ} ]\nCopyright by [ {Publisher} ]";
        }
    }
}
