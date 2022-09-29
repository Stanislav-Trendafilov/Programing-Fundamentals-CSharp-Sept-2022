using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M= int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int targets = 0, firstN = N; ;
            while(M<N)
            {
                N -= M;
                targets++;
                if(2*N==firstN)
                { N /= Y; }
            }
            Console.WriteLine(N);
            Console.WriteLine(targets);
        }

    }
}
