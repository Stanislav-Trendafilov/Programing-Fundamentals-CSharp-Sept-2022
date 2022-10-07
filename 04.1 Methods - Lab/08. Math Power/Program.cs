using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(mathPow(num,power));

        }
        static double mathPow(double a,double b)
        {
            double num = 1;
            if (b == 0)
            { return 1; }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    num *= a;
                }
            }
            return num;
        }
    }
}
