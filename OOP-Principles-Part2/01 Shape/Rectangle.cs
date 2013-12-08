using System;
using System.Linq;

namespace Shape
{
    class Rectangle:Shape
    {
        public Rectangle(int width, int height):base(width,height)
        {
        }
        public override void CalculateSurface()
        {
            double surface = (this.Width * this.Height) ;
            Console.WriteLine("The surface of Rectangle is: {0}",surface);
        }
    }
}
