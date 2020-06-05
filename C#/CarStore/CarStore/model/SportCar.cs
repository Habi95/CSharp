using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore.model
{

     class SportCar : Car
    {
        public SportCar(model.Type type, string brand, Producer producer, int year, int hp, string color, decimal price, Person owner) : base(type,brand,producer,year,hp,color,price,owner)
        {
          
        }

    }
}
