//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmartPhone
//{
//    class Game : App
//    {
//        public Game(string name, AppTypEnum typ, string publisher,
//            bool singlePlayer, bool multiplayer, bool online, bool offline) : base(name, typ, publisher)
//        {


//            SinglePlayer = singlePlayer;
//            Multiplayer = multiplayer;
//            Online = online;
//            Offline = offline;
//        }

//        public bool SinglePlayer { get; set; }
//        public bool Multiplayer { get; set; }
//        public bool Online { get; set; }
//        public bool Offline { get; set; }

//        public override string ToString()
//        {
//            return base.ToString() + $"Singleplayer [ {SinglePlayer} ]\nMultiplayer [ {Multiplayer} ]\n" +
//                $"Online [ {Online} ]\nOfflinee [ {Offline} ]\n";
//        }
//    }


//}
