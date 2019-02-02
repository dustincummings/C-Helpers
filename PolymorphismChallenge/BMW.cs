using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
     // A BMW is a car
    class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hP, string color, string model):base(hP,color)
        {
            this.Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " Color: " + Color );
        }
        // Can only seal override methods does not allow inheritance
        public override void Repair()
        {
            Console.WriteLine($"Your {brand} {Model} was repaired!");
        }
    }
}
