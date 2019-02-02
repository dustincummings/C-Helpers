using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Conversions
    {
        static void Main(string[] args)
        {
            //implicit conversions
            int num = 12356;
            long bigNum = num;

            float myFloat= 13.37f;
            double nyNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            //explicit conversion
            //cast double to int;
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();
            
            Console.WriteLine(myInt);
            Console.Read();

        }



    }
}
