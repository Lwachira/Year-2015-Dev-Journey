using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;
namespace RectangleLibrary
{
    public class Rectangle_CLass : Shape2D
    {
       private bool square;
        private double area;

        public Rectangle_CLass(double h,double w):base(h,w)
        {
             square = isSquare(h,w);
             area = Area(h, w);
        }

        private double Area(double h, double w)
        {
            return w * h;
        }

        public bool isSquare(double height,double weight)
        {
            if (height == weight)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }

        public override string ToString()
        {
            return "Is a square: " + square +"\t" + "The area is:" + area.ToString();
        }

        
    }
}
