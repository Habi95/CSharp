using System;
using Zoo.model;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cage < Ape > apeCage = new Cage<Ape>(CageType.Glass);
            Cage<Tiger> tigerCage = new Cage<Tiger>(CageType.Gitter);
            Ape ape = GenericObject.GenerateObject<Ape>(new object[] {"APE","Bert",CageType.Glass} );
            apeCage.AddAnimal(ape);
            Tiger tiger = GenericObject.GenerateObject<Tiger>(new object[] { "TIGER", "Luzifer", CageType.Glass });
            tigerCage.AddAnimal(tiger);
            apeCage.RemoveAnimal(ape);
           
           
           

            
        }
    }
}
