using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] arg = command.Split(" ");
                if(arg[0]=="Add")
                { 
                    int value = int.Parse(arg[1]);
                    wagons.Add(value);
                }
                else
                {
                    int value = int.Parse(arg[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(value+wagons[i]<=maxCapacity)
                        {
                            wagons[i] += value;
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
