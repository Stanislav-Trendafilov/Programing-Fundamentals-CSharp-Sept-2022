using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> secondHand = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();
            while(firstHand.Count!=0&&secondHand.Count!=0)
            {
                for (int i = 0; i <Math.Min(secondHand.Count,firstHand.Count); i++)
                {
                    int firstCard = firstHand[i];
                    int secondCard = secondHand[i];
                    if(firstCard > secondCard)
                    {
                        firstHand.Add(secondCard);
                        firstHand.Add(firstCard);
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(i);
                    }
                    else if(firstCard < secondCard)
                    {
                        secondHand.Add(firstCard);
                        secondHand.Add(secondCard);
                        secondHand.RemoveAt(i);
                        firstHand.RemoveAt(i);
                    }
                    else
                    {
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(i);
                    }
                }

            }
            if(firstHand.Count==0)
            { Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}"); }
            else if (secondHand.Count == 0)
            { Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}"); }

        }
    }
}
