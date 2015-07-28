using ShapesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLibrary
{
    public class Circle_Class : Shape2D
    {
        private double field;
        private double area;
        public double Field
        {
            get { return field; }
            set { field = value; }
        }

        public Circle_Class(double field,double h,double w) : base(h,w)
        {
           area = Area(field);
        }

        private double Area(double field)
        {
            return Math.PI * Math.Pow(field, 2);
        }

        public override string ToString()
        {
            return "The area of the circle is: " + Math.Round(area).ToString();
        }
    }
}
