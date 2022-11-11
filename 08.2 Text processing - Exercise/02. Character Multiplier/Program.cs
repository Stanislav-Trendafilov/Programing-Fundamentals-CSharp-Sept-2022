using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();
            int suma=0;
            int shorterWordLength = Math.Min(word[0].Length, word[1].Length);
            for (int i = 0; i < shorterWordLength; i++)
            {
                suma += word[0][i] * word[1][i];
            }
            string longerWord = string.Empty;
            if(word[0].Length>word[1].Length)
            {
                longerWord = word[0];
            }
            else
            {
                longerWord = word[1];
            }
            for (int i = shorterWordLength; i < longerWord.Length; i++)
            {
                suma+=longerWord[i];
            }
            Console.WriteLine( suma);
        }
    }
}
