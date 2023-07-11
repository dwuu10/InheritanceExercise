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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var Crow = new Bird();
            Crow.tail = true;
            Crow.teeth = false;
            Crow.canFly = true;
            Crow.call = "Caw caw!";

            var Crocodile = new Reptile();
            Crocodile.tail = true;
            Crocodile.teeth = true;
            Crocodile.Legs = 4;
            Crocodile.longTongue = false;
            Crocodile.basking = "I like to sit in the sun";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine("This is the crow:");

            string crowHasTail = Crow.tail ? "has a tail" : "does not have a tail";
            string crowHasTeeth = Crow.teeth ? "has teeth" : "does not have teeth";
            string crowHasFeathers = Crow.hasFeathers ? "has feathers" : "does not have feathers";
            string crowHasWings = Crow.wings ? "has wings" : "does not have wings";
            string crowCanFly = Crow.canFly ? "can fly" : "cannot fly";

            Console.WriteLine($"The crow {crowHasTail}, {crowHasTeeth}, {crowHasFeathers}, {crowHasWings}, {crowCanFly}, has {Crow.eyes} eyes and {Crow.Legs} legs.");
            Console.WriteLine($"The crow's call is {Crow.call}!");

            Console.WriteLine("");
            
            Console.WriteLine("This is the Crocodile:");

            string crocHasTail = Crocodile.tail ? "has a tail" : "does not have a tail";
            string crocHasTeeth = Crocodile.teeth ? "has teeth" : "does not have teeth";
            string crocHasScales = Crocodile.scales ? "has scales" : "does not have scales";
            string crocHasLongTongue = Crocodile.longTongue ? "has a long tongue" : "does not have a long tongue";
            string crocIsColdBlooded = Crocodile.coldBlooded ? "is cold-blooded" : "is not cold-blooded";

            Console.WriteLine($"The crocodile {crocHasTail}, {crocHasTeeth}, {crocHasScales}, {crocHasLongTongue}, {crocIsColdBlooded}, has {Crocodile.eyes} eyes and {Crocodile.Legs} legs.");
            Console.WriteLine($"When basking, the crocodile says {Crocodile.basking}!");
        }
    }
}
