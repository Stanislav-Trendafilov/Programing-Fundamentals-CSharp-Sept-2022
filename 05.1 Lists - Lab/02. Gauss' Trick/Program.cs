using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();
            int n = numbers.Count;
            for (int i = 0; i < n/2; i++)
            {
                  numbers[i] += numbers[n - i - 1];
                  numbers.RemoveAt(n - i - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
