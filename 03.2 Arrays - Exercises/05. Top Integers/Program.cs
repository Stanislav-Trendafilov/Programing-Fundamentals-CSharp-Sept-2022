using System;
using System.Linq;
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToArray();
            
            for (int i = 0; i <numbers.Length; i++)
            {
                bool isBigger = false;
                for (int j= i+1; j < numbers.Length; j++)
                {
                    if(numbers[i]>numbers[j])
                    { isBigger = true; }
                    else
                    { 
                        isBigger = false;
                        break ;
                    }
                }
                if(isBigger)
                { Console.Write(numbers[i]+" "); }
            }
            Console.Write(numbers[numbers.Length-1]);
        }
    }
}
