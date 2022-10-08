using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(numberOfVowels(text));
        }

        private static int numberOfVowels(string a)
        { 
            int br = 0;
            foreach (char letter in a.ToLower())
            {
                if(letter=='a'|| letter == 'u'|| letter == 'y'|| letter =='e'|| letter == 'o'|| letter == 'i')
                { 
                    br++; 
                }
            }
            return br;
        }
    }
}
