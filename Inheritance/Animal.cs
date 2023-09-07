using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class Animal
// give this class 4 members that all Animals have in common

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public virtual string TempRegulate { get; set; } = "Warm-Blooded"; // virtual keyword allows this to be overriden by reptile class
        public string DietType { get; set; } = "Omnivore";
    }
}
