using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Util;

namespace Breakfast
{
    public class Breakfast
    {


        public  async Task<Coffee> PourCoffee()
        {
            await Task.Delay(3000);
            Console.WriteLine("Start CoffeMaschine");
            await Task.Delay(3000);
            Coffee coffee = Util.Extensions.ObjectExtensions.NewObject<Coffee>();
            Console.WriteLine("Coffee is finished");

            return coffee;
        }

        public  async Task<Juice> PourJuice()
        {
            await Task.Delay(3000);
            Console.WriteLine("Get a glas");
            await Task.Delay(3000);
            Juice juice = Util.Extensions.ObjectExtensions.NewObject<Juice>();
            Console.WriteLine("One glas of Juice");

            return juice;
        }

        public  async Task<Bacon[]> FryBacon(int amount)
        {
            Bacon bacon = Util.Extensions.ObjectExtensions.NewObject<Bacon>();
            bacon.bacons = new Bacon[amount];
            for (int i = 0; i < bacon.bacons.Length; i++)
            {
                Console.WriteLine("Heat the Pan"); 
                await Task.Delay(3000);
                Console.WriteLine("Put bacon to");
                await Task.Delay(2000);
                Console.WriteLine("flipp up");
                await Task.Delay(2000);
                bacon.bacons[i] = Util.Extensions.ObjectExtensions.NewObject<Bacon>();
                Console.WriteLine("bacon is ready");

            }
            return bacon.bacons;
        }

        public static Bacon[] EatBacon(ref Bacon[] bacons, int eated)
        {
            return bacons = bacons.Skip(eated).ToArray();

        }

        public  async Task<Toast[]> ToastBread(int amount)
        {
            Toast toast = Util.Extensions.ObjectExtensions.NewObject<Toast>();
            toast.toasts = new Toast[amount];
            for (int i = 0; i < toast.toasts.Length; i++)
            {
                Console.WriteLine("Put toast in the toaster");
                toast.toasts[i] = Util.Extensions.ObjectExtensions.NewObject<Toast>();
                await Task.Delay(3000);
                Console.WriteLine("Pop Up");
                await Task.Delay(1000);
                Console.WriteLine("Put butter on it");
                Toast.ApplyButter(toast.toasts[i]);
                await Task.Delay(2000);
                Console.WriteLine("Put jam on");
                Toast.ApplyJam(toast.toasts[i]);
                await Task.Delay(2000);
                Console.WriteLine("Toast are ready");
            }
            return toast.toasts;
        }
        







        public  async Task<Egg[]> FryEggs(int amount)
        {
            Egg eggs = Util.Extensions.ObjectExtensions.NewObject<Egg>();

            eggs.eggs = new Egg[amount];
            for (int i = 0; i <= amount; i++)
            {
                Console.WriteLine("Heat the pan");
                await Task.Delay(3000);
                Console.WriteLine("Put the egg in\nstir the egg");
                await Task.Delay(3000);
                Egg fryEggs = Util.Extensions.ObjectExtensions.NewObject<Egg>();
                eggs.eggs[i] = fryEggs;
                Console.WriteLine("Egg are finished");


            }

            return eggs.eggs;
        }


    }
}
