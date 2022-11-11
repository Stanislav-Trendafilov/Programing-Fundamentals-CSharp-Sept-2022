using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sequence = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();
            string[] bombNum = Console.ReadLine().Split(" ");
            double bomb = double.Parse(bombNum[0]);
            int detonation = int.Parse(bombNum[1]);
            for (int i = 0; i < sequence.Count; i++)
            {
                if(sequence[i]==bomb)
                {
                    
                    for (int j = 1;j <= detonation; j++)
                    {
                        if (bomb != sequence[sequence.Count - 1])
                        {
                            sequence.RemoveAt(i + 1);
                        }
                        if (bomb != sequence[0])
                        { 
                            sequence.RemoveAt(i - 1);
                            i -= 1;
                        }
                       
                    }
                    sequence.RemoveAt(i);
                    i -= 1;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
