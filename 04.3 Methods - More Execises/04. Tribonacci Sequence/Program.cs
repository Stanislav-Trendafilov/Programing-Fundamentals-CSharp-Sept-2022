using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            tribonacciSequence(number);
        }
        static void tribonacciSequence(int number)
        {
            int[] arr = new int[number];
            if (number == 0)
            { Console.WriteLine("0"); }
            else if (number == 1)
            { Console.WriteLine("1"); }
            else if (number == 2)
            { Console.WriteLine("1 1"); }
            else
            {
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;
                for (int i = 3; i < number; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                }

                for (int j = 0; j < number; j++)
                {
                    Console.Write(arr[j] + " ");
                }
            }
        }
    }
}
