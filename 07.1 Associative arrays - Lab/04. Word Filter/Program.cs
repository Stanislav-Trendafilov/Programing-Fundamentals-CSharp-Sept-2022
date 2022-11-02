using System;
using System.Linq;
namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
