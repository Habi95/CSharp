using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CarStore.model
{
    class Car
    {
       
        public model.Type Type { get; set; }
        public string Brand { get; set; }
        public Producer Producer { get; set; }
        public int? Year { get; set; }
        public int HP { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Person Owner { get; set; }

        public Car(model.Type type, string brand, Producer producer, int year, int hp, string color, decimal price, Person owner)
        {
            this.Type = type;
            this.Brand = brand;
            this.Producer = producer;
            this.Year = year;
            this.HP = hp;
            this.Color = color;
            this.Price = price;
            this.Owner = owner;

        }
    }
}
