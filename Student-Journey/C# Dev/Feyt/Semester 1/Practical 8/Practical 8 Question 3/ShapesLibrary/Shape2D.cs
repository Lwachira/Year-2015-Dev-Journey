using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Shape2D
    {
        private double height, width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Shape2D()
        {
            height = 1;
            width = 1;
        }

        public Shape2D(double height)
        {
            this.height = height;
            width = 1;
        }

        public Shape2D(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public string showDetails()
        {
            return "The height is: " + height.ToString() + "\t" + "The width is: " + width.ToString();
        }
    }
}
