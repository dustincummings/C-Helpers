using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        //  jagged array is an array that holds multiple arrays
        //  index                     0    1    2   3  
        //normal array of type int :[15],[21],[23],[13]
        //  index                         0                           1                       2
        //jagged array of type int : [array1(12[],[15],[26])],[array2([51],[54],[30])],[array3([48],[56],[7])]

        static void Main(string[] args)
        {
            //declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3, };
            jaggedArray[2] = new int[] { 12, 13 };

            //altenativeway
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3, },
                new int[] { 12, 13 },
            };
            Console.WriteLine($"The value in the middle of the first entry is {jaggedArray2[0][2]}" );//is 5
            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($"Element {i}");
                for(int j = 0; j<jaggedArray2[i].Length; j++)
                    Console.WriteLine($"{jaggedArray2[i][j]}");
            }

            string[][] jaggedFriendArray = new string[][]
            {
                new string []{"Chris","Brady","Bradley"},
                new string []{"Darin","Scarlett","Brian"},

            };
            Console.WriteLine($"Hi {jaggedFriendArray[0][0]}, I'd like to introduce you to {jaggedFriendArray[1][0]} and his daugther {jaggedFriendArray[1][1]}");
            Console.WriteLine($"{jaggedFriendArray[1][0]},{jaggedFriendArray[0][0]} has a son and his name is {jaggedFriendArray[0][1]}");

            Console.ReadKey();
        }
    }
}
