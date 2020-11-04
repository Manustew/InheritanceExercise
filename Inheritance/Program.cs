using System;
using System.Net.Cache;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class*/

            Bird quackers = new Bird()
            {
                Name = "Quackers",
                Age = 1000,
                NumberOfLegs = 2,
                HasBackbone = false,
                CanFly = true,
                Color = "black",
                HasFeathers = true,
                BirdOfPrey = true,
            };


            // Creatively display the class member values 

            Console.WriteLine($"I once had a pet bird named {quackers.Name}. Even though it's {quackers.CanFly} that Quackers can fly, he would often just poke around on his {quackers.NumberOfLegs} legs. " +
            $"It's also {quackers.HasFeathers} that his feathers were {quackers.Color} and that he lived to be {quackers.Age}. It's {quackers.BirdOfPrey} that he was a Bird of Prey." +
            $"He used to catch snakes and small vermon.  But it's {quackers.HasBackbone} that he had a backbone. He was scared of his own shadow.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var albert = new Reptile()
            {
                Name = "Albert",
                Age = 125,
                NumberOfLegs = 4,
                HasBackbone = true,
                IsAmphibious = true,
                HasLegs = true,
                Environment = "Swamp",
                Defense = "fun and gun!",
            };

            Console.WriteLine($"The Florida Gators macot is an Alligator named {albert.Name}. " +
                $"He is {albert.Age} years old and it's {albert.HasLegs} he has {albert.NumberOfLegs} legs." +
                $"Do gators have a backbone?  Are they amphibious? {albert.HasBackbone} and {albert.IsAmphibious}." +
                $"I most enjoy watching albert when he is in the {albert.Environment} running the {albert.Defense}!");
        }
    }
}
