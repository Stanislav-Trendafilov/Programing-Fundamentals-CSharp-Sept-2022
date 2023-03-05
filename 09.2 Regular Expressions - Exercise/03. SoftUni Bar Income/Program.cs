using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|\.\%\$]*\%([A-Z]{1}[a-z]+)\%[^\|\.\%\$]*\<(\w+)\>[^\|\.\%\$]*\|(\d+)\|[^\|\.\%\$\d]*(\d+(\.\d+)?)\$[^\|\.\%\$]*$";
            Regex regex= new Regex(pattern);    
            string input = Console.ReadLine();
            double totalPrice = 0;
            bool anySuccess = false;
            while (input!= "end of shift")
            {
                Match match= regex.Match(input);
                if (match.Success) 
                {
                    anySuccess= true;
                    int quantity = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    totalPrice+= quantity * price;   
                    Console.WriteLine($"{match.Groups[1].Value}: {match.Groups[2].Value} - {(quantity*price):f2}");
                }
                input= Console.ReadLine();  
            }
            if (!anySuccess)
            {  }
            else
            { Console.WriteLine($"Total income: {totalPrice:f2}"); }
        }
    }
}
