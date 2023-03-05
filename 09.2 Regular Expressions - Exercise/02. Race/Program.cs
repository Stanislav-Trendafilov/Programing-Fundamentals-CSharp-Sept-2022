using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string input=Console.ReadLine();
            string patternWords = @"[A-Za-z]";
            Regex regexW=new Regex(patternWords);
            string patternNums = @"[0-9]";
            Regex regexN = new Regex(patternNums);
            Dictionary<string,int>racersInfo= new Dictionary<string,int>();
            while (input!= "end of race")
            {
                string name=string.Empty;
                int points = 0;
                MatchCollection matches= regexW.Matches(input);
                foreach (Match ch in matches)
                {
                   name += ch.Value;     
                }
                MatchCollection matchesNum = regexN.Matches(input);
                foreach (Match ch1 in matchesNum)
                {
                    points += int.Parse(ch1.Value);
                }
                if(names.Contains(name)) 
                {
                    if(!racersInfo.ContainsKey(name))
                    {
                        racersInfo[name] = 0;
                    }
                    racersInfo[name] += points;
                }
               
                input =Console.ReadLine();
            }
            int i = 1;
            foreach (var kvp in racersInfo.OrderByDescending(x=>x.Value))
            {
                if(i==1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                if (i==3)
                {
                    break;
                }
                i++;
            }
        }
    }
}
