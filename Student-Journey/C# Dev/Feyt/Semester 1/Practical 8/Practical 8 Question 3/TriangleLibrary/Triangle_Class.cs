using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;
namespace TriangleLibrary
{



    public class Triangle_Class : Shape2D
    {


        private string style;
        private double area;
        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        public Triangle_Class(string style, double height, double width) : base(height, width)
        {
            this.style = style;
            area = Area(height, width);
        }

        private double Area(double height, double width)
        {
            return width * height / 2;
        }

        public override string ToString()
        {
            return "The style chosen is: " + style + "\t" + "The area is: " + area;
        }
    }



}
