using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 3, 6, 7, 8, 9, 15, 20 };
            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine($"{grade}");
            }
            Console.ReadKey();

            int[] happiness = { 2, 3, 4, 5, 6 };
            Happiness(happiness);
            foreach(int y in happiness)
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();

            Console.WriteLine($"The average grade is {averageResult}");
            Console.ReadKey();
        }
        static void Happiness(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] += 2;
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i =0; i<size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
