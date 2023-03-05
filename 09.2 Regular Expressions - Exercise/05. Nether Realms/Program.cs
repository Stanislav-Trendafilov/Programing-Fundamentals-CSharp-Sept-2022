using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string patternHealth = @"[^\d\.\+\-\/\*]";
            Regex regexHealth = new Regex(patternHealth);

            string patternDamage = @"(\+|-)?\d+(\.\d+)?";
            Regex regexDamage = new Regex(patternDamage);

            string patternSymbol = @"[\*\/]";
            Regex regexSymbol=new Regex(patternSymbol);

            Dictionary<string,string>info= new Dictionary<string,string>();
            foreach (var item1 in input)
            {
                //count all symbols and add their ASCII num to the health
                MatchCollection matches = regexHealth.Matches(item1);           
                int health = 0;
                foreach (Match ch in matches)
                {
                    health += char.Parse(ch.Value);
                }

                //count all nums and add them to the damage
                MatchCollection matchesD = regexDamage.Matches(item1);
                double damage = 0;
                foreach (Match ch1 in matchesD)
                {
                    damage += double.Parse(ch1.Value);
                }

                MatchCollection matchesS = regexSymbol.Matches(item1);
                foreach (Match ch2 in matchesS)
                {
                    if (char.Parse(ch2.Value.ToString()) == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                info[item1] = $"{health} health, {damage:f2} damage";
            }

            foreach (var item in info.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }

    }
}
