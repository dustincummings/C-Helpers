using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Program
    {
        //A Class is  blue print of an Object
        //It has actions/abilities - so called member functions or methods
        //and it has properties - so called member variables
        //inheritance possible
        //can be used like a DataType(e.g. String is a Class)

        //Object Car
        //Properties: HP, Amount of Wheels, Lumen, Doors
        //Abilities: Drive, Brake, Open Window, Make Light
        //Inheritance: E.g. A5<Audi<Car
        static void Main(string[] args)
        {
            // Create an object of my class
            // an instance of Human
            Human Dustin = new Human();
            //access public variable from outside, and even change it
            Dustin.firstName = "Dustin";
            Dustin.lastName = "Cummings";

            Dustin.eyeColor = "green";
            //call methods of the class
            Dustin.IntroduceMyself();

            Human colton = new Human("Colton", "Cummings","blue");
            colton.IntroduceMyself();
            Console.ReadLine();
        }
    }
}
