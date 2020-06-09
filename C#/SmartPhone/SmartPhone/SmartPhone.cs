using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
    class SmartPhone
    {
        public string Brand { get; set; }

        public string Color { get; set; }

        private List<App> appList = new List<App>();

        public List<App> AppList 
        {
            get {
                return appList;
            }
        }
    }
}
