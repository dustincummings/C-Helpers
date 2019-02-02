using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        //if(condition{what to do if condition is met}
        //

        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature outside");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value was not a number. 0 set as temperature");
            }
            if (numTemp < 50)
            {
                Console.WriteLine("take the coat");
            }
            else if (numTemp == 50)
            {
                Console.WriteLine("it is 50 degress F");
            }
            else
            {
                Console.WriteLine("it is cozy");
            }

            Console.Read();
        }
    }
}
