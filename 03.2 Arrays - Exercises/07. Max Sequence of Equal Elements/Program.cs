using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int maxBr = 0,maxNum=0;
            for (int i = numbers.Length-1; i >=0; i--)
            {
                int currentBr = 1;
                for (int j = i-1; j >=0; j--)
                {
                    if(numbers[i]==numbers[j])
                    { currentBr++; }
                    else
                    { break; }
                }
                if(currentBr>=maxBr)
                { 
                    maxNum = numbers[i];
                    maxBr = currentBr;
                }
            }
            for (int i = 0; i < maxBr; i++)
            {
                Console.Write(maxNum+" ");
            }
        }
    }
}
