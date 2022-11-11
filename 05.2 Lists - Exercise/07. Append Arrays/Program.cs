using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine()
                                  .Split('|')
                                  .Reverse()
                                  .ToList();

            foreach (var str in numbersAsStrings)
            {
                int[]numbers = str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                Console.Write(string.Join(" ", numbers));
     
                 Console.Write(" "); 
            }
        }
    }
}
