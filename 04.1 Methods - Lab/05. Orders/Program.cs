using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                Console.WriteLine($"{coffee(quantity):F2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{water(quantity):F2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{coke(quantity):F2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{snacks(quantity):F2}");
            }
        }
        static double coffee(int a)
        {
            double sum = a*1.5;
            return sum;
        }
        static double water(int a)
        {
            double sum = a * 1.0;
            return sum;
        }
        static double coke(int a)
        {
            double sum = a*1.4;
            return sum;
        }
        static double snacks(int a)
        {
            double sum = a *2;
            return sum;
        }
    }
    
}
