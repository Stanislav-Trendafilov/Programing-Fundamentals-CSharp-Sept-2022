 using System;
using System.Linq;
namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int Ind = random.Next(0, arr.Length);
                string swap = " ";
                swap = arr[Ind];
                arr[Ind] = arr[i];
                arr[i] = swap;
            }
            Console.WriteLine(string.Join(Environment.NewLine,arr));
        }
    }
}
