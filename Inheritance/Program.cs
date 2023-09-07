using System;
using System.Collections.Generic;
using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            Bird sparrow = new Bird()
            {

                Name = "Sparrow",
                Habitat = "Forest",

                EggColor = "gray",
                FeatherColor = "light brown",
                WingSpan = 8,

            };

            Console.WriteLine($"Name: {sparrow.Name}");
            Console.WriteLine($"Habitat: {sparrow.Habitat}");
            Console.WriteLine($"Is {sparrow.TempRegulate}.");
            Console.WriteLine($"Diet Type: {sparrow.DietType}");
            Console.WriteLine("");

            sparrow.PrintBirdEgg();
            sparrow.PrintWingDetails();

            Console.WriteLine("---------------------");

            Reptile iguana = new Reptile()
            {

                Name = "Iguana",
                Habitat = "Grassland",

                HatchFromEgg = true,
                EggColor = "pale",

                ScaleColor = "green",

            };

            Console.WriteLine($"Name: {iguana.Name}");
            Console.WriteLine($"Habitat: {iguana.Habitat}");
            Console.WriteLine($"Is {iguana.TempRegulate}.");
            Console.WriteLine($"Diet Type: {iguana.DietType}");
            Console.WriteLine("");

            Console.WriteLine(iguana.PrintReptileScales());
            Console.WriteLine(iguana.PrintReptileEgg());

        }
    }
}


            /* Refrence_Notes

            Wanted to apply this to loop somehow; trying to get class name out of counter from the loop.

            Console.WriteLine(iguana.PrintReptileScales(iguana));  

            Likely have to define another loop matching the class type to access methods of the devrived class.


            Animal[] animalLog = new Animal[2] {iguana, sparrow};




                foreach (var animal in animalLog)
                {

                    //List<int> ind = new List<int>();

                    Console.WriteLine(animal.Name);
                    Console.WriteLine(animal.Habitat);
                    Console.WriteLine(animal.TempRegulate);
                    Console.WriteLine(animal.DietType);



            if (animal is Bird)
            {
                Console.WriteLine(animal.TempRegulate);
                animal.PrintWingDetails();

                Console.WriteLine("------");
            }
            else if (animal is Reptile)
            {
                Console.WriteLine(animal.DietType);
                animal.PrintReptileEgg();


                Console.WriteLine("------");
            }
            else
            {
                Console.WriteLine("-------");
            }

            }
     
        */