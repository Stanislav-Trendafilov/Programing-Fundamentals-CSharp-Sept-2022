using System;
using System.Linq;
namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToArray();
            int magicNum = int.Parse(Console.ReadLine());      
            int []magicNums=new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                bool isUnique = false;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = 0;
                    sum += numbers[i];
                    sum += numbers[j];
                    if(sum==magicNum)
                    {
                        magicNums[0] = numbers[i];
                        magicNums[1] = numbers[j];
                        isUnique = true;
                        break;
                    }
                }

                if (isUnique)
                { Console.WriteLine(string.Join(" ", magicNums)); }
               
            }
        }
    }
}
