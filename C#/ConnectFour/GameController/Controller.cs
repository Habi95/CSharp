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

        public int CheckWinner (int playerToCheck, int[,] board)
        {
            //vertival (|)
            for (int row = 0; row < board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (NumberInRow(playerToCheck, board[row, col], board[row + 1, col], board[row + 1, col], board[row + 1, col]))
                    {
                        return playerToCheck;
                    }
                }
            }
            //horizontal (-)
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1) - 3; col++)
                {
                    if (NumberInRow(playerToCheck, board[row, col], board[row, col + 1], board[row, col + 2], board[row, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }
            //diagonal left (\)

            for (int row = 0; row < board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < board.GetLength(1) - 3; col++)
                {
                    if (NumberInRow(playerToCheck, board[row, col], board[row + 1, col + 1], board[row + 2, col + 2], board[row + 3, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }
            //diagonal reight (/)
            for (int row = 0; row < board.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < board.GetLength(1); col++)
                {
                    if (NumberInRow(playerToCheck, board[row, col], board[row + 1, col - 1], board[row + 2, col - 2], board[row + 3, col - 3]))
                    {
                        return playerToCheck;
                    }
                }
            }

            return 0;
        }

        private bool NumberInRow(int playerID, params int[] numbers)
        {
            foreach (var item in numbers)
            {
                if (item != playerID)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
