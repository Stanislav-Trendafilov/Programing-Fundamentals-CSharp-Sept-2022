using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = string.Empty;
            foreach (char letter in text)
            {
                newText+=(char)(letter + 3);
            }
            Console.WriteLine(newText);
        }
    }
}
