using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // a car can be a BMW, an Audi, a Porsche et.
            // Polymorphism at work #1: an Audi, BMW, Porsche
            // can all be used whereever a CAR is expected. No cast is 
            // reqquired because an implicit conversion exists from a derived
            // class to its base class.]
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", " M3")
            };

            // Polymorphism at work #2: the virtual method Repairs is 
            // invoked on each of the derived classes, not the base class
            // this allows you to have different messages for each class
            // without calling a different method each time.
            foreach(var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "orange", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();
            bmwZ3.SetCarIDInfo(1234, "Dustin Cummings");
            audiA3.SetCarIDInfo(1235, "Allie Sweeney");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            M3 myM3 = new M3(260, "red", "M3 Turbo");
            myM3.Repair();
            Console.ReadKey();
        }
    }
}
