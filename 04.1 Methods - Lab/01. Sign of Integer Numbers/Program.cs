using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            checkNumber(n);
        }
        static void checkNumber(int number)
        { 
            if(number>0)
            { Console.WriteLine($"The number {number} is positive. "); }
            else if(number<0)
            { Console.WriteLine($"The number {number} is negative. "); }
            else
            { Console.WriteLine($"The number {number} is zero. "); }
        }
    }
}
