using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle:Shape
    {
        public Circle(int width,int heigth):base(width,heigth)
        {
            this.Height = width;
            this.Width = width;
        }
        public override void CalculateSurface()
        {

            double surface = Math.PI * (this.Width * this.Width);
            Console.WriteLine("The circle area is: {0:F2}",surface);
        }
    }
}
