using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i< 10; i++)
            {
                nums[i] = i + 10;
            }
            //for(int j = 0; j<10; j++) risky if you try to read more then you have you will get an error 
            for(int j = 0; j < nums.Length; j++)//better solution for this
            {
                Console.WriteLine($"Elements{j} = {nums[j]}");
            }
            int counter = 0;
            foreach(int k in nums)//best for this solution does not need to know how many or where to start
            {
                Console.WriteLine($"Element {counter} = {k}");
                counter++;
            }
            Console.ReadKey();

            string[] friends = new string[] { "Colton", "Darin", "Brian", "Chris", "Pat" };

            foreach(string s in friends)
            {
                Console.WriteLine($"Good Morning, {s}");
            }

            Console.ReadLine();
        }
    }
}
