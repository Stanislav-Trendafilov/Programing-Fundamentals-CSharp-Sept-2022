using System;
using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{products[i-1]}");
            }
        }
    }
}
