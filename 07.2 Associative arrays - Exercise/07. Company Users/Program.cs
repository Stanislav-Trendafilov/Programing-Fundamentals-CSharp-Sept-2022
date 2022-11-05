using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input!="End")
            {
                string[] cmdArg = input.Split(" -> ");
                string company = cmdArg[0];
                string id = cmdArg[1];
                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }
                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id); 
                }
                input = Console.ReadLine();
            }
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var worker in company.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
