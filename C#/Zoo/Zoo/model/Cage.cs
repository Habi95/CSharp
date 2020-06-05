using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.model
{
    class Cage<T> 
    {
        List<T> cageList = new List<T>();
        public CageType Type { get; set; }

        public Cage(CageType type)
        {
            Type = type;
        }

        public void AddAnimal(T animal)
        {
            
            cageList.Add(animal);
                Console.WriteLine("is in cage");
            
            
        }

        public void RemoveAnimal(T animal)
        {
            int index = cageList.IndexOf(animal);
            cageList.RemoveAt(index);
            Console.WriteLine("delete");
        }
    }

    
}
