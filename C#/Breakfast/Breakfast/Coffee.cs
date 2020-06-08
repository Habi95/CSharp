using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace Breakfast
{
    public class Coffee
    {
        private string temperature;
        public string Temperature 
        {
            get { return TemperatureOfCoffe(temperature) ;}
            set { temperature = value; }
        }

       

        public  string TemperatureOfCoffe(string value)
        {
            if (value == null)
            {
                temperature = "Hot";
            }
           else if (value.Equals("Hot") )
            {
                temperature = "Quite hot";
            }
            else if (value.Equals("Quite hot"))
            {
                temperature = "Not so hot";
            }
            else if (value.Equals("Not so hot"))
            {
                temperature = "Cold";
            }
            return temperature;


        }
    }
}
