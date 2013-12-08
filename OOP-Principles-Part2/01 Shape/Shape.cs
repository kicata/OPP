using System;
using System.Linq;


namespace Shape
{
    public abstract class Shape
    {
        private int width;
        private int height;
        //properties
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        //costructor
        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract void CalculateSurface();
        
    }
}
