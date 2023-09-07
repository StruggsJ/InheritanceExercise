using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class

namespace Inheritance
{
    public class Reptile : Animal
    {
        public override string TempRegulate { get; set; } = "Cold-Blooded"; // From Animal Class

        public bool HatchFromEgg { get; set; }

        public string EggColor { get; set; }

        public string ScaleColor { get; set; }

        public string PrintReptileEgg()
        {

            if (HatchFromEgg == true)
            {
                return $"{Name}s hatch from an egg. The color of its eggs are {EggColor}.";
            }
            else
            {
                return $"{Name}s do not hatch from an egg.";
            }
        }

        public string PrintReptileScales()
        {
            return $"The color of a {Name}'s scales are {ScaleColor}.";
        }
    }
}
