using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in words)
            {
                string word = item.ToLower();
                if(!count.ContainsKey(word))
                {
                    count.Add(word, 0);
                }
                count[word] += 1;
            }
            foreach (var item in count)
            {
                if(item.Value%2!=0)
                { Console.Write(item.Key+" "); }
            }
            
        }
    }
}
