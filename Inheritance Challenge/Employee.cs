using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public Employee() { }
        public void Work()
        {
            Console.WriteLine("Im working");
        }
        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
