using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
  public static class PathStorage
    {
       public static void SavePath(Path paths)
       {
           StreamWriter writer=new StreamWriter(@"../../savedData.txt",false,Encoding.GetEncoding("windows-1251"));
           using (writer)
           {
               foreach (var item in paths.PathOfPoints )
               {
                   writer.WriteLine(item);
               }
           }
       }
       public static List<Path> LoadPath()
       {
           StreamReader reader = new StreamReader(@"../../LoadPoints.txt");
           Path newList = new Path();
           List<Path> pathLoaded = new List<Path>();
           using (reader)
           {
               string lineOfText = reader.ReadLine();

               while (lineOfText!=null)
               {
                   string[] coordinates = lineOfText.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
                   Point3D point = new Point3D();
                   point.X = int.Parse(coordinates[0]);
                   point.Y = int.Parse(coordinates[1]);
                   point.Z = int.Parse(coordinates[2]);
                   
                   newList.AddPoint(point);
                   lineOfText = reader.ReadLine();
               }
               pathLoaded.Add(newList);
           }
           return pathLoaded;
       }
       
    }
}
