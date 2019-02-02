using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBirthDate = new DateTime(1984,11,15);


            Console.WriteLine($"My birthday is {myBirthDate}");
            // Write today on screen
            Console.WriteLine(DateTime.Today);
            //Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();

            Console.WriteLine($"Tomorrow is {tomorrow}");
            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");
            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Feb 2000 had {days} days");
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine($"Feb 2001 had {days} days");
            days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine($"Feb 2002 had {days} days");
            days = DateTime.DaysInMonth(1984, 2);
            Console.WriteLine($"Feb 1984 had {days} days");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Hour: {now.Hour} Min: {now.Minute}");
            Console.WriteLine($"Hour: {now.Hour} Min: {now.Minute} Sec: {now.Second}");


            Console.WriteLine("Write a date in this format:yy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out myBirthDate ))
            {
                Console.WriteLine(myBirthDate);
                TimeSpan daysPassed = now.Subtract(myBirthDate);
                Console.WriteLine($"Days Passed since :{daysPassed.Days}");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadLine();
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
