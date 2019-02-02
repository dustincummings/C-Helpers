using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        //Save time
        //Quick and easy repetition of code
        //Allows you to work with huge amounts of Data
        //Allows you to loop through Arrays

        //types
        //1. for loop - (start value; condition; increment){ code body} great for counters
        //2. while loop(check then go) counterVariable = 0  while(condition){execute your code counterVariable++'} Executes code as long as the condition is met

        //3. do while loop (do first then check) counterVariable = 0 do{execute your code counterVariable++'}  while(condition) Executes code as long as the condition is met
        //4. foreach loop (Run through array or list) only as long as there is content

        static void Main(string[] args)
        {
            for (int counter = 50; counter > 0; counter -= 5)//counter ++ adds 1 counter +=5 adds 5 counter-- subtracts 1 counter -+ counter -=5 subtracts 5
            {
                Console.WriteLine(counter);
            }
            //DoWhileLoop
            //int lengthOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the name of a friend");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLength = nameOfAFriend.Length;
            //    lengthOfText += currentLength;
            //    wholeText += nameOfAFriend;
            //} while (lengthOfText < 20);
            //Console.WriteLine("Thanks, that was enough! " + wholeText);
            //While Loop
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                    " enter if you want to finish counter");
                enteredText = Console.ReadLine();
                i++;
                Console.WriteLine("Current people count is {0}", i);

            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program.",i);
            Console.Read();
        }
    }
}
