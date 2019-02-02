using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        //Ex. Car - Base prop: HP, windows, wheels Methods: drive, honk ALL cars have this.
        // Deriving Classes Race Car prop: Turbo Method: Racing  Street Car prop: Comfort method: StreetRide

        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Dustin Cummings");
            Console.WriteLine(post1.ToString());


            ImagePost imagePost = new ImagePost("Check out my new shoes","Dustin Cummings", "https://images.com/shoes", true);
            VideoPost videoPost = new VideoPost("Fail Video", "Dustin Cummings", "https://video.com/video", true, 5);


            Console.WriteLine(imagePost.ToString());
            Console.WriteLine(videoPost.ToString());

            videoPost.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost.Stop();
            

            Console.ReadKey();
        }
    }
}
