using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int fn = int.Parse(Console.ReadLine());
            int sn = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine( adding(fn, sn));
            }
            else if(command=="multiply")
            { 
                Console.WriteLine(multiply(fn, sn));
            }
            else if (command == "subtract")
            {
                Console.WriteLine(subtract(fn, sn));
            }
            else if(command=="divide")
            { 
                Console.WriteLine(divide(fn, sn));
            }
        }
        static int adding(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int multiply(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        static int subtract(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
        static int divide(int a, int b)
        {
            int sum = a / b;
            return sum;
        }

    }
}
