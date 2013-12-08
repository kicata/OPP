using System;
using System.Linq;

namespace Shape
{
    class Triangle:Shape
    {
        public Triangle(int width, int height):base(width,height)
        {
        }
        public override void CalculateSurface()
        {
            double surface = (this.Width * this.Height) / 2;
            Console.WriteLine("The surface of triangle is: {0:F2}",surface);
        }
    }
}
