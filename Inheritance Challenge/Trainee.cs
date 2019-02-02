using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(string name, string firstName, int salary ,int workingHours, int schoolHours) : base(name,firstName, salary )
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

       public void Learn()
        {
            Console.WriteLine($"I'm learning for {SchoolHours} hours");
        }
        public void Work()
        {
            Console.WriteLine($"I would for {WorkingHours} hours!");
        }

    }
}
