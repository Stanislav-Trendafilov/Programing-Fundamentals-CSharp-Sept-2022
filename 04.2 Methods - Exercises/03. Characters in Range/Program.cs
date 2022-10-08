using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharactersInRange(firstChar, secondChar);
        }

        private static void CharactersInRange(char firstChar, char secondChar)
        {
            char swap;
            if((int)secondChar<(int)firstChar)
            {
                swap = firstChar;
                firstChar = secondChar;
                secondChar = swap;
            }
            for (int i = (int)firstChar+1; i < (int)secondChar; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
