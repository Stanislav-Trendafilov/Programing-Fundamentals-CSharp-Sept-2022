using System;

namespace _02._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int suma = 0;
            string text = Console.ReadLine();
            foreach (char letter in text)
            {
                if((int)firstChar<(int)letter&&(int)letter<(int)secondChar)
                {
                    suma += (int)letter;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
