using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class

namespace Inheritance
{
   public class Bird : Animal
    {
        public override string TempRegulate { get; set; } = "Warm-Blooded"; 
        public string EggColor { get; set; }
        public string FeatherColor { get; set; }   
        public int WingSpan { get; set; }

        public void PrintWingDetails()
        {
            Console.WriteLine($"The {Name}'s wings color are {FeatherColor}.");
            Console.WriteLine($"A {Name}'s wingspan is {WingSpan} inches.");
        }

        public void PrintBirdEgg()
        {
            Console.WriteLine($"The {Name}'s egg color is {EggColor}.");
        }
            

        
    }
}
