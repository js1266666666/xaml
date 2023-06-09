using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_RectangleClass
{
    public class Rectangle
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }
        public double GetArea()
        {
            double area = width * height;
            return area;
        }

        public double GetPerimiter()
        {
            double perimitter = (width * 2) + (height * 2);
            return perimitter;
        }
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle(5, 3);
            double area = Rect.GetArea();
            double perimeter = Rect.GetPerimiter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}
