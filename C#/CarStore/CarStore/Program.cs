using CarStore.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CarStore
{

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            List<Producer> producers = new List<Producer>();
            List<model.Type> types = new List<model.Type>();
            Person shopOwner = new Person("Fred", 35, 10000);
            Person customer1 = new Person("Sabine", 32, 200000);
            Person customer2 = new Person("Herwig", 56, 15000);
            Store fredsGarage = new Store("Freds Garage", shopOwner, shopOwner.MoneyPouch);
            Car AudiA6 = new Car(model.Type.Coupee, "Audi A6", Producer.VW, 2015, 180, "Black", 50_000, shopOwner);
            fredsGarage.ShowCars.Add(AudiA6);
            Car BmwM6 = new Car(model.Type.Cabrio, "BMW M6", Producer.BMW, 2013, 560, "Orange", 47_990, shopOwner);
            fredsGarage.ShowCars.Add(BmwM6);
            SportCar California = new SportCar(model.Type.Sport, "Ferrari California", Producer.Ferrari, 2010, 460, "Red", 119_000, shopOwner);
            fredsGarage.ShowCars.Add(California);
            SportCar Ghibli = new SportCar(model.Type.Coupee, "Maserati Ghibli", Producer.Maserati, 2020, 430, "Blue", 83_377, shopOwner);
            fredsGarage.ShowCars.Add(Ghibli);
            SportCar Panamera = new SportCar(model.Type.Sport, "Porsche Panamera", Producer.Porsche, 2020, 330, "Black", 124_000, shopOwner);
            fredsGarage.ShowCars.Add(Panamera);
            SportCar AMG = new SportCar(model.Type.Sport, "Mercedes-Benz C 63 AMG", Producer.MercedesBenz, 2020, 517, "AliceBlue", 179_000, shopOwner);
            fredsGarage.ShowCars.Add(AMG);

            types.Add(model.Type.Cabrio);
            types.Add(model.Type.Coupee);
            types.Add(model.Type.Kleinwagen);
            types.Add(model.Type.Kombi);
            types.Add(model.Type.Sport);
            producers.Add(Producer.BMW);
            producers.Add(Producer.Ferrari);
            producers.Add(Producer.Maserati);
            producers.Add(Producer.MercedesBenz);
            producers.Add(Producer.Porsche);
            producers.Add(Producer.VW);


            



            while (run)
            {


                Console.WriteLine();
                Console.WriteLine("Willkommen zur Persönlicher Auto erstellung \n\n" + "0 für ein normales Auto / 1 für einen Sportwagen / 2 für alle autos anzeigen / 3 zum Beenden\n\n");
                int choiceOfCar = Console.ReadLine().ReadInt();
                switch (choiceOfCar)
                {
                    case 0:
                        BuildYourCar(producers, types, shopOwner, fredsGarage.ShowCars);
                        break;
                    case 1:
                        BuildYourSportCar(producers, types, shopOwner, fredsGarage.ShowCars);
                        break;
                    case 2:
                        foreach (Car car in fredsGarage.ShowCars)
                                    {
                                        Console.WriteLine($"{car.Producer},{car.Brand},{car.Type},{car.HP},{car.Color},{car.Year},{car.Price},");
                                    }
                        break;
                    case 3:
                        run = false;
                        break;
                }
            }
                




            }

            public static void BuildYourSportCar(List<Producer> producers, List<model.Type> types, Person shopOwner, List<Car> ShowCars)
            {
                Console.WriteLine("Folgende Hersteller stehen zur verfügung:");
                for (int i = 0; i < producers.Count; i++)
                {
                    Console.WriteLine(i + ": " + producers.ElementAt(i));

                }
                Console.WriteLine("\nFolgende Typen: ");
                Console.WriteLine($"0: {types.ElementAt(0)}  \n1: {types.ElementAt(1)}  \n3: {types.ElementAt(3)}  \n4: {types.ElementAt(4)} \n");
                Console.WriteLine("Hersteller wählen:");
                int choiceProducer = Console.ReadLine().ReadInt();
                Console.WriteLine("Serie wählen:");
                string choiceName = Console.ReadLine();
                Console.WriteLine("Typ wählen:");
                int choiceType = Console.ReadLine().ReadInt();
                Console.WriteLine("Baujahr wählen:");
                int choiceYear = Console.ReadLine().ReadInt();
                Console.WriteLine("PS wählen:");
                int choiceHp = Console.ReadLine().ReadInt();
                Console.WriteLine("Farbe wählen:");
                string choiceColor = Console.ReadLine();
                Console.WriteLine("Price wählen:");
                decimal choicePrice = Console.ReadLine().ReadDecimal();
                SportCar mySportCar = new SportCar(types.ElementAt(choiceType), choiceName, producers.ElementAt(choiceProducer), choiceYear, choiceHp, choiceColor, choicePrice, shopOwner);
            ShowCars.Add(mySportCar);

            }

            public static void BuildYourCar(List<Producer> producers, List<model.Type> types, Person shopOwner, List<Car> ShowCars)
            {
                Console.WriteLine("Folgende Hersteller stehen zur verfügung:");
                Console.WriteLine($"0: {producers.ElementAt(0)}  \n3: {producers.ElementAt(3)}  \n5: {producers.ElementAt(5)} \n");


                Console.WriteLine("\nFolgende Typen:\n ");
                Console.WriteLine($"0: {types.ElementAt(0)}  \n1: {types.ElementAt(1)}  \n2: {types.ElementAt(2)}  \n3: {types.ElementAt(3)} \n");
            Console.WriteLine("Hersteller wählen:");
            int choiceProducer = Console.ReadLine().ReadInt();
            Console.WriteLine("Serie wählen:");
            string choiceName = Console.ReadLine();
            Console.WriteLine("Typ wählen:");
            int choiceType = Console.ReadLine().ReadInt();
            Console.WriteLine("Baujahr wählen:");
            int choiceYear = Console.ReadLine().ReadInt();
            Console.WriteLine("PS wählen:");
            int choiceHp = Console.ReadLine().ReadInt();
            Console.WriteLine("Farbe wählen:");
            string choiceColor = Console.ReadLine();
            Console.WriteLine("Price wählen:");
            decimal choicePrice = Console.ReadLine().ReadDecimal();
            Car myCar = new Car(types.ElementAt(choiceType), choiceName, producers.ElementAt(choiceProducer), choiceYear, choiceHp, choiceColor, choicePrice, shopOwner);
            ShowCars.Add(myCar);

        }

    }
}

