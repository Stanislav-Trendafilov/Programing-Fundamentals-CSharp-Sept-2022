using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> strings = new Dictionary<char, int>();
            string word = Console.ReadLine();
            foreach (var ch in word)
            {
                if (ch != ' ')
                {
                    if (!strings.ContainsKey(ch))
                    {
                        strings[ch] = 0;
                    }
                    strings[ch] ++;
                }
            }
            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
