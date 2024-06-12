using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            Animal animal = new Animal();

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            Bird bird = new Bird();

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            Reptile reptile = new Reptile();



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            bird.Name = "Eagle";
            bird.Age = 5;
            bird.EyeColor = "Black";
            bird.Sound = "Caw";
            bird.WingColor = "Brown";
            bird.BeakType = "Sharp";
            bird.FeatherType = "Soft";
            bird.Habitat = "Mountains";

            bird.BirdDescription();
            Console.WriteLine("\n\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            reptile.Name = "Snake";
            reptile.Age = 2;
            reptile.EyeColor = "Blue";
            reptile.Sound = "Hiss";
            reptile.IsColdBlooded = true;
            reptile.ScaleColor = "Green";
            reptile.Habitat = "Jungle";
            reptile.HasLegs = false;

            reptile.BirdDescription();
        }
    }
}
