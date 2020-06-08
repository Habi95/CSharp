using System;
namespace Breakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            Breakfast breakfast = Util.Extensions.ObjectExtensions.NewObject<Breakfast>();
            Coffee coffee = Breakfast.PourCoffee();
            



            

        }
    }
}
