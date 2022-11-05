using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while(input!="stop")
            {
                int count = int.Parse(Console.ReadLine());
                if(!resourses.ContainsKey(input))
                {
                    resourses.Add(input,count);
                }
                else
                {
                    resourses[input] += count;
                }
                input = Console.ReadLine();
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
