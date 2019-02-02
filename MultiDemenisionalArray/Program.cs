using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDemenisionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2d array
            string[,] matrix;
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
            // declare 3d array
            int[,,] threeD;

            // 2d array
            int[,] array2D = new int[,]
            {
                {1,2,3 },//row 0 index 0=1 1=2 2=3
                {4,5,6},//row 1 index 0=4 1=5 2=6
                {7,8,9 },//row 2 index 0=7 1=8 2=9
            };
            Console.WriteLine($"Central value of this 2D array is {array2D[1,1]}");//[row1,index1]=5
            Console.WriteLine($"The value of row 2 and index 0 of this 2D array is {array2D[2,0]}");//[row2,index0]=7

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" }, 
                { "five", "six" }
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine($"The new value is {array2DString[1,1]}");//changing "four" to "chicken

            int dimensions = array2DString.Rank;
            Console.WriteLine($"This array has {dimensions} dimensions!");//gives the number of dimensions of an array

            // 3D array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" },// the first set of rows will be 0,0,#
                    {"010","011" },// the second set of rows will be 0,1,#
                },
                {//both have too have same amount of rows
                    {"100","101" },// the first set of second numbers will be 1,0,#
                    {"110","111" }// the second set of second numbers will be 1,1,#
                }
            };
            Console.WriteLine($"The value of the 3D array is {array3D[0,1,0]}");//[set0, row1,index0]=010


            Console.ReadKey();
        }
    }
}
