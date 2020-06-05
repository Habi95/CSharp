using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore.model
{
    class Store
    {


        public string ShopName { get; set; }
        public Person owner { get; set; }
        public decimal Wealth { get; set; }

        public List<Car> ShowCars = new List<Car>();

        public Store(string shopName, Person owner, decimal wealth)
        {
            ShopName = shopName;
            this.owner = owner;
            Wealth = wealth;
        }
    }
}
