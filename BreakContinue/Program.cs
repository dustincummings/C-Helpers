using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("Stop at 3!");
                    break;//stops the program
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We skipped 3!");
                    continue;//skip the current entry
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i %2 == 0)//this will print the CW every other line CW,1,CW,3,CW,5 ....
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
