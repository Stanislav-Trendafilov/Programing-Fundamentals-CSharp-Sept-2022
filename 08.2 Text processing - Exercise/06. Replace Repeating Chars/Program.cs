using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char previouEl = ' ';
            var newWord = new StringBuilder();
            foreach (var item in word)
            {
                if(item!=previouEl)
                {
                    newWord.Append(item);
                }
                previouEl = item;
            }
            Console.WriteLine(newWord);
        }
    }
}
