using System;
using System.Linq;
//Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace Point3D
{
     static class CalculateDistance
    {

        public static double CalcDist(Point3D first, Point3D second)
        {
            int x1 = first.X;
            int x2 = second.X;

            int y1 = first.Y;
            int y2 = second.Y;

            int z1 = first.Z;
            int z2 = second.Z;

            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

            return distance;
        }
    }
}
