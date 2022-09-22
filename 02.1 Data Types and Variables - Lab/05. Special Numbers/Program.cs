﻿using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i  = 1; i  <=number; i++)
            {
                sum = 0;
                int currentNum = i; 
                while (currentNum > 0)
                {
                    sum+=currentNum% 10;
                    currentNum /= 10;
                }
                if(sum==5||sum==7||sum==11)
                { Console.WriteLine($"{i} -> True"); }
                else
                { Console.WriteLine($"{i} -> False"); }
            }
        }
    }
}