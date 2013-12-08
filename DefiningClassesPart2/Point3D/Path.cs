using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        public readonly List<Point3D> PathOfPoints=new List<Point3D>(); 

        public void AddPoint(Point3D point)
        {
           this.PathOfPoints.Add(point);
        }
        public void Clear()
        {
            this.PathOfPoints.Clear();
        }
    }
}
