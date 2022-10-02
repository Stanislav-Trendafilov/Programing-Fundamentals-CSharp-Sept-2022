using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int j = 0; j < rotations; j++)
            {
                int firstEl = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstEl;
            }
           
            Console.WriteLine(string.Join(" ",arr));
        
        }
    }
}
