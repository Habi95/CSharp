using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Breakfast breakfast = Util.Extensions.ObjectExtensions.NewObject<Breakfast>();

            var coffeeTask = breakfast.PourCoffee();
            var juiceTask = breakfast.PourJuice();
            var eggTask = breakfast.FryEggs(5);
            var baconTask = breakfast.FryBacon(6);
            var toastTask = breakfast.ToastBread(6);

            var brakfastTasks = new List<Task> { coffeeTask, juiceTask, eggTask, baconTask, toastTask };

            while (brakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(brakfastTasks);
                if (finishedTask == eggTask)
                {
                    Console.WriteLine("All Eggs are readey");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("All Bacons are ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("Toasts are ready");
                }
                else if (finishedTask == coffeeTask)
                {
                    Console.WriteLine("Cooffffffeee");
                }
                else if (finishedTask == juiceTask)
                {
                    Console.WriteLine("im dirsty  glook gloook");
                }
                brakfastTasks.Remove(finishedTask);                

            }
            Console.WriteLine("Breakfast finished");



            

        }
    }
}
