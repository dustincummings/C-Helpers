using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Bosses:Employee
    {
        public string CompanyCar { get; set; }

        public void Lead()
        {
            Console.WriteLine($"I'm your boss and my name is {FirstName} {Name}!!");
        }

        public Bosses() { }
        public Bosses(string name, string firstName, int salary, string companyCar):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;
        }
    }
}
