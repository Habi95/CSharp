using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataModels;

namespace SmartPhoneController
{
    public class Controller
    {   

        private SmartPhone mySmartPhone;
        public SmartPhone MySmartPhone 
        { 
            get
            {
                return mySmartPhone;
            }
            set
            {
                mySmartPhone = value;
            }
        }
        public List<string> output = new List<string>();


        public Controller(SmartPhone mySmartPhone)
        {
            this.MySmartPhone = mySmartPhone;
        }

        public void loadAppList ()
        {
            App wörterbuch = Util.Extensions.ObjectExtensions.GenerateObject<App>(new object[] { "Wörterbuch", AppTypEnum.Wissen, "Luca" });
            mySmartPhone.AddAppList(wörterbuch);
            App einkaufsliste = Util.Extensions.ObjectExtensions.GenerateObject<App>(new object[] { "Einkaufsliste", AppTypEnum.Shopping, "Luca" });
            mySmartPhone.AddAppList(einkaufsliste);
            Game game = Util.Extensions.ObjectExtensions.GenerateObject<Game>(new object[] { "Snake", AppTypEnum.Gaming, "Luca",true,false,false,true});
            mySmartPhone.AddAppList(game);
        }

        public List<string> showApps()
        {
            
            return output = mySmartPhone.AppList.Select(x => $"{x.Name} - {x.Typ}").ToList();

        }

        public List<string> showComboBox()
        { 
            return output = mySmartPhone.AppList.Select(x => $"{x.Typ}").Take(3).ToList();
        }

        public List<string> getByAppType(string type)
        {

            return output = mySmartPhone.AppList.Where(x =>
                            x.Typ.ToString().Equals(type))
                                .Select(x =>
                                    $"{x.Name} - {x.Typ}").ToList();
        }

        public string showAppPerName(string name)
        {
            
            return mySmartPhone.AppList.Where(x =>
                   x.Name.Equals(name)).
                        Select(x => $"Play {x.ToString()}").FirstOrDefault();
            
        }

        public void startSnake ()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();            
            startInfo.FileName = "java";
            startInfo.Arguments = @"-jar C:\Users\DCV\Desktop\HelloWorld\RemoteDigitalCampus\html\myFirstWebsite\asset\SnakeYT.jar";
            process.StartInfo = startInfo;
            process.Start();
            
        }


    }
}
