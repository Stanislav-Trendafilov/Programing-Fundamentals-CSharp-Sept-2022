using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Change_List
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
            while(command!="end")
            {
                string[] arg = command.Split(" ");
                if(arg[0]=="Delete")
                {
                    int value = int.Parse(arg[1]);
                    numbers.RemoveAll(x=> x==value);
                }

                else if (arg[0]=="Insert")
                { 
                    int element = int.Parse(arg[1]);
                    int index = int.Parse(arg[2]);
                    numbers.Insert(index, element);
                }
                command = Console.ReadLine(); 
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
