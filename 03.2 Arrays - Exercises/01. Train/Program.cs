using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i <n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            foreach (var num in numbers)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(sum);
        }
    }
}
