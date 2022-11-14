using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while(input!="find")
            {
                string code=string.Empty;
                int i = 0;
                foreach (char letter in input)
                {
                    if(i==arr.Length)
                    { i = 0; }
                    code += (char)(letter - arr[i]);
                    i++;
                }
                input = Console.ReadLine();
                int first=code.IndexOf('&');
                int last = code.LastIndexOf('&');
                string type = code.Substring(first+1, last-first-1);
                int firstC = code.IndexOf('<');
                int lastC = code.LastIndexOf('>');
                string cordinate= code.Substring(firstC + 1, lastC - firstC - 1);
                Console.WriteLine($"Found {type} at {cordinate}");
            }
        }
    }
}
