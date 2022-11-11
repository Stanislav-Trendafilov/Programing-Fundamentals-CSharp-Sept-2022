using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");
            foreach (var word in text)
            {
                bool isValid = false;
                if (word.Length >= 3 && word.Length <= 16)
                {
                    foreach (var el in word)
                    {
                        if (char.IsLetterOrDigit(el) || el == '-' || el == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                
                if(isValid)
                { Console.WriteLine(word); }
            }
        }
    }
}
