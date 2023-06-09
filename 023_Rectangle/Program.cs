using System;

namespace _023_Rectangle
{
    class Rectangle
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public double GetArea()
        {
            return width * height;
        }
        public double Getperimeter()
        {
            return (width *2) + (height *2);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            double area = rect.GetArea();
            double perimeter = rect.Getperimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}
