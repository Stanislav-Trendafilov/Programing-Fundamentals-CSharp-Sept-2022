using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] =int.Parse( Console.ReadLine());
            }
            Console.WriteLine(minNumber(arr));
          
        }
        static int minNumber(int[] arr)
        {
            int minNum = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]< minNum)
                { minNum = arr[i]; }
            }
            return minNum;
        }
    }
}
