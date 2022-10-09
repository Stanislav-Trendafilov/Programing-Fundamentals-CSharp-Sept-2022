using System;

namespace Methods___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            if (length(X1, Y1, X2, Y2) > (length(X3, Y3, X4, Y4)))
            {
                if (distanceToCentre(X1, Y1) < distanceToCentre(X2, Y2))
                {
                    Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
                }
                else if (distanceToCentre(X1, Y1) > distanceToCentre(X2, Y2))
                {
                    Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
                }
                else 
                { Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})"); }
            }
            else if (length(X1, Y1, X2, Y2) < (length(X3, Y3, X4, Y4)))
            {
                if (distanceToCentre(X3, Y3) < distanceToCentre(X4, Y4))
                {
                    Console.WriteLine($"({X3}, {Y3})({X4}, {Y4})");
                }
                else if (distanceToCentre(X3, Y3) > distanceToCentre(X4, Y4))
                {
                    Console.WriteLine($"({X4}, {Y4})({X3}, {Y3})");
                }
                else
                { Console.WriteLine($"({X3}, {Y3})({X4}, {Y4})"); }
            }
            if (length(X1, Y1, X2, Y2) == (length(X3, Y3, X4, Y4)))
            {
                if (distanceToCentre(X1, Y1) < distanceToCentre(X2, Y2))
                {
                    Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
                }
                else if (distanceToCentre(X1, Y1) > distanceToCentre(X2, Y2))
                {
                    Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
                }
                else
                { Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})"); }
            }


        }

        private static double distanceToCentre(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            return distance;
        }
        private static double length(double a, double b, double c, double d)
        {
            double width = 0, height = 0;
            if (a >= 0 && c >= 0)
            {
                if (a >= c)
                { width = a - c; }
                else
                { width = c - a; }
            }
            else if (a <= 0 && c <= 0)
            {
                if (a >= c)//-2 -7
                { width = Math.Abs(c) - Math.Abs(a); }
                else
                { width = Math.Abs(a) - Math.Abs(c); }
            }
            else if ((a >= 0 && c <= 0) || (a <= 0 && c >= 0))
            {
                width = Math.Abs(a) + Math.Abs(c);
            }

            if (b >= 0 && d >= 0)
            {
                if (b >= d)
                { height = b- d; }
                else
                { height = d - b; }
            }
            else if (b <= 0 && d <= 0)
            {
                if (b >= d)
                { width = Math.Abs(d) - Math.Abs(b); }
                else
                { width = Math.Abs(b)- Math.Abs(d); }
            }
            else if ((b >= 0 && d <= 0) || (b <= 0 && d >= 0))
            {
                width = Math.Abs(b) + Math.Abs(d);
            }

            double length = Math.Sqrt(Math.Pow(Math.Abs(width), 2) + Math.Pow(Math.Abs(height), 2));
            return length;
        }
    }

}
