using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Volume { get; set; }
        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }
        public Box()
        {
                
        }

        public int FrontSurface
        {
            get => Height * Length;//read-only property
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {Length} and height is {Height} and width is {Width} so the volume is {Volume}");
        }
    }
}
