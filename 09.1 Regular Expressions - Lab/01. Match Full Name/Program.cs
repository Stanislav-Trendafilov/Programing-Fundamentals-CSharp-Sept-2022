using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            //Creating regex pattern
            Regex regex = new Regex(pattern);
            //Find all matches with this pattern in the input
            MatchCollection matches = regex.Matches(input);
            //print all matches 
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
