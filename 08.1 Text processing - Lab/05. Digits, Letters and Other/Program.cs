using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string numbers = string.Empty;
            string chars = string.Empty;
            string oders = string.Empty;
            foreach (var el in text)
            {
                if(char.IsDigit(el))
                {
                    numbers += el;
                }
                else if(char.IsLetter(el))
                {
                    chars += el;
                }
                else
                {
                    oders += el;
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(chars);
            Console.WriteLine(oders);
        }
    }
}
