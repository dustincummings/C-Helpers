using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsC
{
    class Program
    {
        struct Game // similar to Class but must have a value cannot have a default constructor
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void Display()
            {
            Console.WriteLine($"Game 1's name is {name}");
            Console.WriteLine($"Game 1's developer is {developer}");
            Console.WriteLine($"Game 1's rating is {rating}");
            Console.WriteLine($"Game 1's was released {releaseDate}");
            }

        }
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Madden";
            game1.developer = "EA Sports";
            game1.rating = 4.5;
            game1.releaseDate = "Aug. 2018";

            game1.Display();
            Console.ReadLine();
        }
    }
}
