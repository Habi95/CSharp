using GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{
    public class Controller
    {
        FourWinsEntities entities = new FourWinsEntities();
        Highscore player1;
        Highscore player2;

        public Controller(int idPlayer1, string namePlayer1,int idPlayer2, string namePlayer2)
        {
            player1 = new Highscore();
            player1.id = idPlayer1;
            player2.name = namePlayer1;
            player2 = new Highscore();
            player2.id = idPlayer2;
            player2.name = namePlayer2;
        }


    }
}
