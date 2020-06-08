using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Util;

namespace Breakfast
{
    public  class Breakfast
    {

       
        public static Coffee PourCoffee()
        {

            Coffee coffee = Util.Extensions.ObjectExtensions.NewObject<Coffee>();
            return coffee;
        }

        public static Bacon[] FryBacon(int amount)
        {
            Bacon bacon = Util.Extensions.ObjectExtensions.NewObject<Bacon>();
            bacon.bacons = new Bacon[amount];
            for (int i = 0; i < bacon.bacons.Length; i++)
            {
                bacon.bacons[i] = Util.Extensions.ObjectExtensions.NewObject<Bacon>();
            }
            return bacon.bacons;
        }

        public static Bacon[] EatBacon(ref Bacon[] bacons, int eated)
        {
           return bacons = bacons.Skip(eated).ToArray();
            
        }

        public static Toast[] ToastBread(int amount)
        {
            Toast toast = Util.Extensions.ObjectExtensions.NewObject<Toast>();
            toast.toasts = new Toast[amount];
            for (int i = 0; i < toast.toasts.Length; i++)
            {
                toast.toasts[i] = Util.Extensions.ObjectExtensions.NewObject<Toast>();
            }
            return toast.toasts;
        }

       




        public static Egg[] FryEggs(int amount)
        {
           Egg eggs = Util.Extensions.ObjectExtensions.NewObject<Egg>();

            eggs.eggs = new Egg[amount];
            for (int i = 1; i <= amount; i++)
            {

                Egg fryEggs = Util.Extensions.ObjectExtensions.NewObject<Egg>();
                eggs.eggs[i - 1] = fryEggs;


            }
           
            return eggs.eggs;
        }


    }
}
