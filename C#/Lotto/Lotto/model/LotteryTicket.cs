using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto.model
{
    class LotteryTicket
    {
        public int LuckyNumberOne { get; set; }
        public int LuckyNumberTwo { get; set; }
        public int LuckyNumberThree { get; set; }
        public int LuckyNumberFour { get; set; }
        public int LuckyNumberFive { get; set; }
        public int LuckyNumberSix { get; set; }

        public LotteryTicket(int luckyNumberOne, int luckyNumberTwo, int luckyNumberThree, int luckyNumberFour, int luckyNumberFive, int luckyNumberSix)
        {
            LuckyNumberOne = luckyNumberOne;
            LuckyNumberTwo = luckyNumberTwo;
            LuckyNumberThree = luckyNumberThree;
            LuckyNumberFour = luckyNumberFour;
            LuckyNumberFive = luckyNumberFive;
            LuckyNumberSix = luckyNumberSix;
        }
        public void RandomNumberGener()
        {
            Random ranNum = new Random();
            this.LuckyNumberOne = ranNum.Next(1,10);
            this.LuckyNumberTwo = ranNum.Next(1,10);
            this.LuckyNumberThree = ranNum.Next(1,10);
            this.LuckyNumberFour = ranNum.Next(1,10);
            this.LuckyNumberFive = ranNum.Next(1,10);
            this.LuckyNumberSix = ranNum.Next(1,10);
        }

        public bool LuckynumberChecker(LotteryTicket random, LotteryTicket ticket)
        {
            bool HasWon = false;
            int counter = 0;
            if (ticket.LuckyNumberOne == random.LuckyNumberOne)
            {
                Console.Write($"[ {random.LuckyNumberOne} |");
                counter++;
            }
            else
            {
                Console.Write("[ X |");
                         }
            if (ticket.LuckyNumberTwo == random.LuckyNumberTwo)
            {
                Console.Write($" {random.LuckyNumberTwo} |");
                counter++;
            }
            else
            {
                Console.Write(" X |");
                
            }
            if (ticket.LuckyNumberThree == random.LuckyNumberThree)
            {
                Console.Write($" {random.LuckyNumberThree} |");
                counter++;
            }
            else
            {
                Console.Write(" X |");
                
            }
            if (ticket.LuckyNumberFour == random.LuckyNumberFour)
            {
                Console.Write($" {random.LuckyNumberFour} |");
                counter++;
            }
            else
            {
                Console.Write(" X |");
                
            }
            if (ticket.LuckyNumberFive == random.LuckyNumberFive)
            {
                Console.Write($" {random.LuckyNumberFive} |");
                counter++;
            }
            else
            {
                Console.Write(" X |");
               
            }
            if (ticket.LuckyNumberSix == random.LuckyNumberSix)
            {
                Console.Write($" {random.LuckyNumberSix} ]");
                counter++;                
            }
            else
            {
                Console.Write(" X ]");               
            }

            if (counter == 6)
            {
                HasWon = true;
            }
            else
            {
                HasWon = false;
            }
            return HasWon;
        }

        public override string ToString()
        {
            return $"[ {LuckyNumberOne} / {LuckyNumberTwo} / {LuckyNumberThree} / {LuckyNumberFour} / {LuckyNumberFive} / {LuckyNumberSix} ]";
        }

       
    }

}
