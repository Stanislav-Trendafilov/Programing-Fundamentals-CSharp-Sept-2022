using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
           string pattern = @">>([A-Za-z]+)<<(?<type>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?";
           List<string> types = new List<string>();
           Regex regex = new Regex(pattern);
           string inputLine = Console.ReadLine();
           double sum = 0;
           while (inputLine != "Purchase")
           {
               Match match = regex.Match(inputLine);
               if (match.Success)
               {
                   string type = match.Groups[1].Value;
                   double price = double.Parse(match.Groups[4].Value);
                   int count = int.Parse(match.Groups[5].Value);
                   sum += price*count;
                   types.Add(type);
               }
               inputLine = Console.ReadLine();
           }
           
           Console.WriteLine("Bought furniture:");
           foreach (string item in types)
           {
               Console.WriteLine(item);
           }
           Console.WriteLine($"Total money spend: {sum:f2}");
          
        }
    }
}
