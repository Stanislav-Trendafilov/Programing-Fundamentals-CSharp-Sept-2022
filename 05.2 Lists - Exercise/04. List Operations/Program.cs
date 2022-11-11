using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while(command!="End")
            {
                string[] arg = command.Split(" ");
                if(arg[0]=="Add")
                {
                    int value = int.Parse(arg[1]);
                    numbers.Add(value);
                }
                else if (arg[0] == "Insert")
                {
                    int value = int.Parse(arg[1]);
                    int index = int.Parse(arg[2]);
                    if (validateIndex(numbers, index))
                    { 
                        numbers.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index"); 
                    }
                }
                else if (arg[0] == "Remove")
                {
                    int index = int.Parse(arg[1]);
                    if (validateIndex(numbers, index))
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    { Console.WriteLine("Invalid index"); }
                }
                else if (arg[1] == "left")
                {
                    int count = int.Parse(arg[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int first = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (arg[1] == "right")
                {
                    int count = int.Parse(arg[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int last = numbers[numbers.Count-1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0,last);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers ));
        }
        static bool validateIndex(List<int> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count)
            { return false; }
            else return true;
        }
    }
}
