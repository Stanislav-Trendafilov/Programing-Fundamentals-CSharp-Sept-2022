using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                isTopNumber(i);
            }
        }
        private static void isTopNumber(int n)
        {
            int sum = 0;
            int br = 0;
            int currentNumber = n;
            while(n!=0)
            { 
                int currentDigit = n % 10;
                sum += currentDigit;
                if(currentDigit%2!=0)
                { br++; }
                n /= 10;

            }
            if (sum % 8 == 0 && br >= 1)
            { Console.WriteLine(currentNumber); }
            else
            { Console.Write(""); }
        }
    }
}
