using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            bool flag = false;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] arg = input.Split(" ");
                if (arg[0] == "Add")
                {
                    int value = int.Parse(arg[1]);
                    numbers.Add(value);
                    flag = true;
                }
                else if (arg[0] == "Remove")
                {
                    int value = int.Parse(arg[1]);
                    numbers.Remove(value);
                    flag = true;
                }
                else if (arg[0] == "RemoveAt")
                {
                    int value = int.Parse(arg[1]);
                    numbers.RemoveAt(value);
                    flag = true;
                }
                else if (arg[0] == "Insert")
                {
                    int value = int.Parse(arg[1]);
                    int index = int.Parse(arg[2]);
                    numbers.Insert(index, value);
                    flag = true;
                }
                else if(arg[0]== "Contains")
                {
                    int value = int.Parse(arg[1]);
                    if(numbers.Contains(value))
                    { Console.WriteLine("Yes"); }
                    else
                    { Console.WriteLine("No such number"); }
                }
                else if(arg[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i]%2==0)
                        { Console.Write($"{numbers[i]+" "}"); }
                    }
                    Console.WriteLine("");
                }
                else if (arg[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        { Console.Write($"{numbers[i] + " "}"); }
                    }
                    Console.WriteLine("");
                }
                else if (arg[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (arg[0] == "Filter")
                {
                    string condition = arg[1];
                    int value = int.Parse(arg[2]);
                    if(condition== "<")
                    {
                          for (int i = 0; i < numbers.Count; i++)
                          {
                                if(numbers[i]<value)
                                { Console.Write($"{numbers[i]} "); }
                          }
                    }
                    else if (condition == "<=")
                    {
                          for (int i = 0; i < numbers.Count; i++)
                          {
                                if (numbers[i] <= value)
                                { Console.Write($"{numbers[i]} "); }
                          }
                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= value)
                            { Console.Write($"{numbers[i]} "); }
                        }
                    }
                    else if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > value)
                            { Console.Write($"{numbers[i]} "); }
                        }
                    }
                    Console.WriteLine("");
                }
                
                input = Console.ReadLine();
            }
            if (flag)
            { Console.WriteLine(string.Join(" ", numbers)); }
        }
    }
}
