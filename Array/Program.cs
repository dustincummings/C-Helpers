using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        //Stores a fixed size sequential collection of elements
        // Only of the Same type but can be all kinds of types int, string, object, etc.
        //Great to store a collection of data-easier to think of a collection of variables of the same type
        //stored at contiguous memory locations
        // Array's indexes always start at 0 and increase by 1.

        //Declaring an array: dataType [] arrayNames; ex. int[] grades;
        //Initializing an array: dataType[] arrayNames = new dataType[amountOfEntries]; ex. int[] grades = new int[5];
        //Assigning Values to an array: arrayName[index] = value; ex. grades[0]=15; grades[1]=12;
        static void Main(string[] args)
        {
            //declare and initialize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 6;
            grades[3] = 18;
            grades[4] = 2;
            //2nd way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 30, 50, 15, 52 };
            //3rd way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 20, 30, 50, 15, 52 };
            //getting the length of an array use the property of Length
            Console.WriteLine($"Length of gradesOfMathStudentsA: {gradesOfMathStudentsA.Length}");

            Console.WriteLine($"grades at index 0: {grades[0]}");
            // assign value to array grades at index 0
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0: {0}", grades[0]);
            Console.ReadKey();



        }
    }
}
