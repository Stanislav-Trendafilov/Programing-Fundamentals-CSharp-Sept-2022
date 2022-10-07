using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(num), GetSumOfOddDigits(num)));

        }
        static double GetSumOfEvenDigits(int num)
        {
            double sum = 0;
            int absNum = Math.Abs(num);
            while(absNum!=0)
            {
                int lastDigit = absNum % 10;
                if(lastDigit%2==0)
                { sum += lastDigit; }
                absNum /= 10;

            }
            return sum;
        }
        static double GetSumOfOddDigits(int num)
        {
            double sum = 0;
            int absNum = Math.Abs(num);
            while (absNum != 0)
            {
                int lastDigit = absNum % 10;
                if (lastDigit % 2 ==1)
                { sum += lastDigit; }
                absNum /= 10;

            }
            return sum;
        }
        static double GetMultipleOfEvenAndOdds(double a,double b)
        {
            double multiply = a * b;
            return multiply;
        }

    }
}
