using Lotto.model;
using System;
using System.Collections.Generic;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            LotteryTicket random = new LotteryTicket(0, 0, 0, 0, 0, 0);
            random.RandomNumberGener();

            Console.WriteLine("Willkommen zur heutigen Lotto ziehung! \n Bitte geben Sie Ihre Glückszahlen ein: 1 - 9");
            Console.WriteLine("Glückszahl 1:");
            int LuckyNumberOne = Console.ReadLine().ReadInt();
            Console.WriteLine("Glückszahl 2:");
            int LuckyNumberTwo = Console.ReadLine().ReadInt();
            Console.WriteLine("Glückszahl 3:");
            int LuckyNumberThree = Console.ReadLine().ReadInt();
            Console.WriteLine("Glückszahl 4:");
            int LuckyNumberFour = Console.ReadLine().ReadInt();
            Console.WriteLine("Glückszahl 5:");
            int LuckyNumberFive = Console.ReadLine().ReadInt();
            Console.WriteLine("Glückszahl 6:");
            int LuckyNumberSix = Console.ReadLine().ReadInt();
            LotteryTicket lotteryTicket = new LotteryTicket(LuckyNumberOne, LuckyNumberTwo, LuckyNumberThree, LuckyNumberFour, LuckyNumberFive, LuckyNumberSix);

            Console.WriteLine($"Ihre Glückszahlen sind: \n{lotteryTicket.ToString()}\n");



            if (random.LuckynumberChecker(random, lotteryTicket))
            {
                Console.WriteLine("\nConnGratzz!!!");
                Console.WriteLine($"Die heutige Zahlen sind: \n {random.ToString()}");
            }
            else
            {
                Console.WriteLine($"\nHeute Leider nicht den JackPot Gekanckt \nDie heutige Zahlen sind: \n{random.ToString()}");
            }
        }
    }
}
