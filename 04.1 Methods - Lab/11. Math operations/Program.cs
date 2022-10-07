using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double fn = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double sn = double.Parse(Console.ReadLine());

            if (command == "+")
            {
                Console.WriteLine(adding(fn, sn));
            }
            else if (command == "*")
            {
                Console.WriteLine(multiply(fn, sn));
            }
            else if (command == "-")
            {
                Console.WriteLine(subtract(fn, sn));
            }
            else if (command == "/")
            {
                Console.WriteLine(divide(fn, sn));
            }
        }
        static double adding(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static double multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }
        static double subtract(double a, double b)
        {
            double sum = a - b;
            return sum;
        }
        static double divide(double a, double b)
        {
            double sum = a / b;
            return sum;
        }
    }
}

