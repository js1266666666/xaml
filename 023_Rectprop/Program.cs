using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Rectprop
{
    public class Rectangle
    {
        public double Width { get; set; }//속성은 public, 필드는 private
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public double GetArea()
        {
            return Width * Height;
        }
        public double Getperimeter()
        {
            return (Width * 2) + (Height * 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3,6);
            Rectangle r = new Rectangle();
            r.Width = 5;
            r.Height = 5;

            Console.WriteLine("rect 넓이: " + rect.GetArea());
            Console.WriteLine("rect 둘레: " + rect.Getperimeter());
            Console.WriteLine("r 넓이: " + r.GetArea());
            Console.WriteLine("r 둘레:" + r.Getperimeter());


        }
    }
}
