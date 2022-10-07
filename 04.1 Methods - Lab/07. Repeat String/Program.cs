using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result=reverseString(input, n);
            Console.WriteLine(result);
        }

        private static string reverseString(string input, int n)
        {
            string result="";
            for (int i = 0; i < n; i++)
            {
               result += input;
            }
            return result;
        }
    }
}
