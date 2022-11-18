using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            //foreach (Match item in matches)
            //{
            //    Console.Write(item.Value+", ");
            //}
            string[] result = matches.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
