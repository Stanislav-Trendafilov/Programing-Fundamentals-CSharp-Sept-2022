using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, lastDigit = 0, numCopy = n, fact = 1;
            while (sum < n)
            {
                fact = 1;
                lastDigit = numCopy % 10;
                numCopy = numCopy / 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }
                sum = fact + sum;
                if(numCopy==0)
                { break ; }
            }
            if (sum == n)
            { Console.WriteLine("yes"); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
