using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int value = int.Parse(Console.ReadLine());
                dataTypes(value);
            }
            else if(input=="real")
            {
                double value = double.Parse(Console.ReadLine());
                dataTypes(value);
            }
            else if(input=="string")
            {
                string value = Console.ReadLine();
                dataTypes(value);
            }

        }

        private static void dataTypes(int a)
        {
            Console.WriteLine(2*a);
        }
        private static void dataTypes(double a)
        {
            Console.WriteLine($"{(1.5 * a):F2}");
        }
        private static void dataTypes(string a)
        {
            Console.WriteLine($"${a}$");
        }

    }
}
