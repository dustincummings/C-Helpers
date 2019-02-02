using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators modify the value of the related varible
            num3 = -num1;
            Console.WriteLine("num3 is{0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is{0}", num);
            Console.WriteLine("num is{0}", num++);
            //pre increment 
            Console.WriteLine("num is{0}", ++num);

            //decrement operator
            num--;
            Console.WriteLine("num is{0}", num);
            Console.WriteLine("num is{0}", num--);
            //pre decrement 
            Console.WriteLine("num is{0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2; //module gives you the remainder
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //rational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            // first = is assigning, == is comparing
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);
            // != is not equal
            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            //conditional operators
            bool isLowerAndIsSunny;
            isLowerAndIsSunny = isLower && isSunny; // both have to be true to be true.
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndIsSunny);

            isLowerAndIsSunny = isLower || isSunny;// only one condition has to be true for it to be true
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndIsSunny);


            Console.ReadKey();
        }
    }
}
