using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber= double.Parse(Console.ReadLine());
            Console.WriteLine($"{(factroriel(firstNumber)/factroriel(secondNumber)):f2}");
        }

        private static double factroriel(double firstNumber)
        {
            double factoriel = 1;
            for (int i =(int) firstNumber; i > 0; i--)
            {
                factoriel *= i;
            }

            return factoriel;
        }
    }
}
