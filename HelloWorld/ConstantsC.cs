using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //constants are immutable values which are known at compile time and do not change for the life of the progam

    class ConstantsC
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string bDay = "11-15-1984";
        
        static void Help()
        {

            Console.WriteLine("My birthday is always going to be: {0}", bDay);
            Console.ReadKey();
        }
    }
}
