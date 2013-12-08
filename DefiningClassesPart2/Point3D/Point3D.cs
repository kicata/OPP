using System.Text;
////Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

namespace Point3D
{
    public struct Point3D
    {
        public static readonly Point3D PointO = new Point3D(0, 0, 0);
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            StringBuilder textCollect = new StringBuilder();
            textCollect.AppendFormat("Coordinate X: {0}", this.X.ToString());
            textCollect.AppendLine();
            textCollect.AppendFormat("Coordinate Y: {0}", this.Y.ToString());
            textCollect.AppendLine();
            textCollect.AppendFormat("Coordinate Z: {0} \n", this.Z.ToString());
            return textCollect.ToString();
        }
    }
}
