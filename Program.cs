using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
namespace LOP
{
    public class Rectangle
    {
        public double width { get; set; }
        public double height { get; set;}
        public Rectangle()
        {}
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            double area = width*height;
            return area;
        }
        public double GetPerimeter()
        {
            double perimeter = (width + height) * 2;
            return perimeter;
        }
        public string Display()
        {
            string rectangleInfo = "Rectangle's width = " + width + "Retangle's height = " + height;
            return rectangleInfo;
        }
    }
    public class ThucThi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle's width and height:");
            double width = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine(rectangle.Display());
            Console.WriteLine("Rectangle's area = "+rectangle.GetArea());
            Console.WriteLine("Rectangle's perimeter = "+rectangle.GetPerimeter());
        }
    }
}