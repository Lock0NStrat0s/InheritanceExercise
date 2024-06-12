using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string WingColor { get; set; }
        public string BeakType { get; set; }
        public string FeatherType { get; set; }
        public string Habitat { get; set; }

        public void BirdDescription()
        {
            Console.WriteLine($"DESCRIPTION:\n\nName: {Name}\nAge: {Age}\nEye Colour: {EyeColor}\nSound: {Sound}\n\nWing Colour: {WingColor}\nBeak Type: {BeakType}\nFeather Type: {FeatherType}\nHabitat: {Habitat}");
        }
    }
}
