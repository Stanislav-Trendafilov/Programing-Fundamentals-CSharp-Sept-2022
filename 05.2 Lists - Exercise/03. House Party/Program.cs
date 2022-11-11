using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");
                string name = command[0];
                if (command.Contains("not"))
                {
                    if(guestList.Contains(name))
                    { 
                        guestList.Remove(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is not in the list!");
                }
                else 
                {
                    if (!guestList.Contains(name))
                    {
                        guestList.Add(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is already in the list!");

                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
