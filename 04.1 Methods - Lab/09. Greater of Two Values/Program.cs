using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                getMax(firstInt, secondInt);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                getMax(firstChar, secondChar);
            }
            else if (type == "string")
            {
                getMax(firstValue, secondValue);
            }
        }
        static void getMax(int a, int b)
        {
            if (a > b)
            { Console.WriteLine(a); }
            else if (b > a)
            { Console.WriteLine(b); }
        }
        static void getMax(char a, char b)
        {
            if (a > b)
            { Console.WriteLine(a); }
            else if (b > a)
            { Console.WriteLine(b); }
        }
        static void getMax(string a, string b)
        {
            int rersult = a.CompareTo(b);
            if (rersult > 0)
            { Console.WriteLine(a); }
            else
            { Console.WriteLine(b); }
        }

    }
}
