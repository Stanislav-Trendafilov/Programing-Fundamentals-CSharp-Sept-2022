using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(rectangleArea(width,height));
        }
        static double rectangleArea(double a,double b)
        {
            double area = a * b;
            return area;
        }
    }
}
