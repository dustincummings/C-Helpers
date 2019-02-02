using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Length = 5;
            box.Height = 3;
            box.Width = 4;
            box.Volume = box.Height * box.Width * box.Length;
            Console.WriteLine($"Front surface of the box is {box.FrontSurface}");
            box.DisplayInfo();
            Console.ReadKey();
        }
    }
}
