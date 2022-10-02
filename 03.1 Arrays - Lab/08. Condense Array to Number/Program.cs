using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0,totalSum=0;
            for (int i = 0; i < A.Length-1; i++)
            {
                sum = 0;
                sum = A[i] + A[i + 1];
                totalSum += sum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
