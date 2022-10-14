using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while(input!="end")
            {
                string[] arg = input.Split(" ");
                if(arg[0]=="Add")
                {
                    int value = int.Parse(arg[1]);
                    numbers.Add(value);
                }
                else if(arg[0]=="Remove")
                {
                    int value = int.Parse(arg[1]);
                    numbers.Remove(value);
                }
                else if (arg[0] == "RemoveAt")
                {
                    int value = int.Parse(arg[1]);
                    numbers.RemoveAt(value);
                }
                else if (arg[0] == "Insert")
                {
                    int value = int.Parse(arg[1]);
                    int index= int.Parse(arg[2]);
                    numbers.Insert(index,value);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
