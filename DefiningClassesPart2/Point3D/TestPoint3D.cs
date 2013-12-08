using System;
using System.Collections.Generic;
using System.Linq;

namespace Point3D
{
  
    class TestPoint3D
    {
         public static void Main()
        {
            //test struct 3D
            Point3D point = new Point3D(1, 2, 3);
            Point3D pointTwo = new Point3D(4, 5, 6);
            double distBtw2Poins = CalculateDistance.CalcDist(point, pointTwo);
            Console.WriteLine("The distance between 2 point is {0}",distBtw2Poins);

            //testing PathStorage
            //write
            Path pathToWrite = new Path();
            
            pathToWrite.AddPoint(point);
            pathToWrite.AddPoint(pointTwo);
            PathStorage.SavePath(pathToWrite);
            Console.WriteLine();
            Console.WriteLine("Check the project folder for saved file.");
            Console.WriteLine();

            //read
            List<Path> readedPath = PathStorage.LoadPath();
            Console.WriteLine("This is the points from readed file:" );
           
            foreach (var path in readedPath)
            {
                
                foreach (var pointers in path.PathOfPoints)
                {
                    Console.WriteLine(pointers);
                }
                
            }
        }
    }
}
