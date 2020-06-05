using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore.model
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal MoneyPouch { get; set; }

        public Person(string name, int age, decimal moneyPouch)
        {
            Name = name;
            Age = age;
            MoneyPouch = moneyPouch;
        }
    }


}
