using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                string day = item.Groups[2].Value;
                string month = item.Groups[3].Value;
                string year= item.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
        }
    }
}
