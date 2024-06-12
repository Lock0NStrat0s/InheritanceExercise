using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string ScaleColor { get; set; }
        public string Habitat { get; set; }
        public bool HasLegs { get; set; }

        public void BirdDescription()
        {
            Console.WriteLine($"DESCRIPTION:\n\nName: {Name}\nAge: {Age}\nEye Colour: {EyeColor}\nSound: {Sound}\n\nCold-blooded: {IsColdBlooded}\nScale Colour: {ScaleColor}\nHabitat: {Habitat}\nHas Legs: {HasLegs}");
        }
    }
}
