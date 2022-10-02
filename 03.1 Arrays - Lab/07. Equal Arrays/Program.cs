using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] B = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int diffInd = 0,sum=0;
            bool areSame = true;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]!=B[i])
                {
                    diffInd = i;
                    areSame = false;
                    break;
                }
                else
                { 
                    sum += A[i];
                }

            }
            if(!areSame)
            { Console.WriteLine($"Arrays are not identical. Found difference at {diffInd} index"); }
            else
            { Console.WriteLine($"Arrays are identical. Sum: {sum}"); }

        }
    }
}
