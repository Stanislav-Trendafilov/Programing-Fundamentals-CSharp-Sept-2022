using System;
using System.Linq;
namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
             .Split(" ")
             .Select(int.Parse)
             .ToArray();
            int index = 0;
            bool sameSums = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0, sumRight = 0;
                
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sumRight += numbers[j];
                }
                for (int k = 0; k < i; k++)
                {
                    sumLeft += numbers[k];
                }
                if (sumLeft==sumRight)
                { 
                    sameSums = true;
                    index = i;
                }
            }
            if(sameSums)
            { Console.WriteLine(index); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
