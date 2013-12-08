using System;
using System.Linq;


//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at
//initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior
//of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.


namespace Shape
{
    class ShapeTest
    {
        static void Main()
        {
            Shape[] container = new Shape[3];
            container[0] = new Triangle(2, 5);
            container[1] = new Rectangle(15, 2);
            container[2] = new Circle(15, 2);

            foreach (var shape in container)
            {
                shape.CalculateSurface();
            }
        }
    }
}
