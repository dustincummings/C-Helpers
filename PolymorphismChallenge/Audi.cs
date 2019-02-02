using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hP, string color, string model) : base(hP, color)
        {
            this.Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " Color: " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine($"Your {brand} {Model} was repaired!");
        }
    }
}
