using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{

    enum Day { Mon =1, Tue, Wed, Thur, Fri, Sat, Sun}
    enum Months { Jan=1, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec};
    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;

            Day a = Day.Fri;

            Console.WriteLine(fr == a);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);
            Console.ReadKey();
        }
    }
}
