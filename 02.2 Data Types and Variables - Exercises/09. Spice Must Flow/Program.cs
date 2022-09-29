using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int  production = 0, days = 0;
            bool a = false;
            while(n>=100)
            {
                a = true;
                production += n;
                production -= 26;
                n -= 10;
                days++;
            }
            if (a)
            {
                Console.WriteLine(days);
                Console.WriteLine(production - 26);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(production);
            }
        }
    }
}
