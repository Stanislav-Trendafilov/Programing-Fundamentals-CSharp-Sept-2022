using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            if (distanceToCentre(X1, Y1) < distanceToCentre(X2, Y2))
            { Console.WriteLine($"({X1}, {Y1})"); }
            else if (distanceToCentre(X1, Y1) > distanceToCentre(X2, Y2))
            { Console.WriteLine($"({X2}, {Y2})"); }
            else
            { Console.WriteLine($"({X1}, {Y1})"); }
        }

        private static double distanceToCentre(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            return distance;
        }
    }
}
