using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(calculations(a, b, c));
        }

        private static int calculations(int a, int b, int c)
        {
            return a + b - c;
        }
    }
}
