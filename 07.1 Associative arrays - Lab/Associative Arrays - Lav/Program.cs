using System;
using System.Collections.Generic;
using System.Linq;
namespace Associative_Arrays___Lav
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            foreach (var item in arr)
            {
                if(!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 0);
                }
                numbers[item] += 1;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
