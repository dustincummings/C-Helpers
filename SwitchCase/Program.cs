using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young");
                    break;
                case 25:
                    Console.WriteLine("Good to Go");
                    break;
                default:
                    Console.WriteLine("Wow your old");
                    break;
            }
            // Same as above
            if(age == 15)
            {
                Console.WriteLine("Too young");
            }
            else if(age == 25)
            {
                Console.WriteLine("Good to Go");
            }
            else
            {
                Console.WriteLine("Wow your old");
            }

            string userName = "Steve";

            switch (userName)
            {
                case "Dustin":
                    Console.WriteLine("Username is Dustin");
                    break;
                case "Root":
                    Console.WriteLine("Username is Root");
                    break;
                default:
                    Console.WriteLine("Username is Unknown");
                    break;

            }

            Console.Read();
        }
    }
}
