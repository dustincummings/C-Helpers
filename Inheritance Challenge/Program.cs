using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee toby = new Employee("Toby","Cummings", 1000000);

            toby.Work();
            toby.Pause();

            Bosses chuckNorris = new Bosses("Norris", "Chuck", 1000000, "Ferrari");

            chuckNorris.Lead();

            Trainee maizie = new Trainee("Sweeney", "Maizie", 20000, 32, 8);
            maizie.Learn();
            maizie.Work();
            Console.ReadKey();

        }
    }
}
