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


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            Bird Woody = new Bird()
            {
            Name = "Woody",
            Age = 10,
            IsAlive = true,
            Legs = 2,
            Wings = 2,
            CanFly = true,
            HasFeathers = true,
            BeakSize = 2.5,

        };
            Console.WriteLine($"{Woody.Name} is a bird {Woody.Age} years old that has {Woody.Wings} wings and {Woody.Legs}  legs " +
                $"{Woody.HasFeathers},{Woody.CanFly},{Woody.IsAlive}, and his beak is {Woody.BeakSize}");
            Console.WriteLine($"Woody can fly, has feathers, and is very much alive ");
            
            Console.WriteLine("------------------------------");
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile Snake1 = new Reptile()
            {
                Name = "Snake1",
                Age = 9,
                IsAlive = true,
                Legs = 0,
                IsColdBlooded = true,
                IsScaley = false,
                Length = 5,
                Habtat = "outside",
        };
            Console.WriteLine($"{Snake1.Name} is {Snake1.Age} year old that is {Snake1.Length} foot, he lives {Snake1.Habtat} ");
            Console.WriteLine($"{Snake1.Name} is cold blooded and is not scaley but does live outside");
            Console.WriteLine($"{Snake1.IsScaley},{Snake1.IsColdBlooded},{Snake1.IsAlive}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
