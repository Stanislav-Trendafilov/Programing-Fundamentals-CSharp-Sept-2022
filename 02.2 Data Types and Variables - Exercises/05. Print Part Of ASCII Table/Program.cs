using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCh = int.Parse(Console.ReadLine());
            int lastCh = int.Parse(Console.ReadLine());
            for (int i = firstCh; i <= lastCh; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
