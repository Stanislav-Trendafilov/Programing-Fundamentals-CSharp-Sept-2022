using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine()
            .Split(" ")
            .Select(double.Parse)
            .ToList();
            List<double> numbers2 = Console.ReadLine()
           .Split(" ")
           .Select(double.Parse)
           .ToList();
            int lowerCount = Math.Min(numbers1.Count, numbers2.Count);
            for (int i = 0; i < Math.Max(numbers1.Count, numbers2.Count); i++)
            {
                if(i<lowerCount)
                { Console.Write(numbers1[i] + " " + numbers2[i]+" "); }
                else
                {
                    if (numbers1.Count > numbers2.Count)
                    { Console.Write(numbers1[i]+" "); }
                    else
                    { Console.Write(numbers2[i]+" "); }
                }
            }
        }
    }
}
