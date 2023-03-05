using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string pattern = @"^[^\@\-|!\:\>]*?\@(?<planet>[A-Za-z]+)[^\@\-|!\:\>]*?\:\d+[^\@\-|!\:\>]*?\!(?<attackType>[A,D])\![^\@\-|!\:\>]*?\-\>\d+[^\@\-|!\:\>]*?$"; 
            Regex regex= new Regex(pattern);
            Dictionary<string,List<string>> planets= new Dictionary<string,List<string>>();
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMEssage=DecryptMessage(encryptedMessage);
                Match match= regex.Match(decryptedMEssage);
                if(match.Success) 
                {
                    string planetName = match.Groups["planet"].Value;
                    string attacktype = match.Groups["attackType"].Value;
                    if (!planets.ContainsKey(attacktype))
                    { planets[attacktype] = new List<string>(); }
                    planets[attacktype].Add(planetName);
                }
                
            }
            int br = 0;
            int br1 = 0;
            bool a = false;
            foreach (var kvp in planets)
            {     
                if (br!=1)
                {
                    if (kvp.Key == "D")
                    {
                        Console.WriteLine($"Attacked planets: 0");
                        a = true;
                    }
                    else
                    { Console.WriteLine($"Attacked planets: {kvp.Value.Count}"); }
                    br= 1;
                }
                if(br1 != 1 && br == 1 && kvp.Key !="A")
                {
                    Console.WriteLine($"Destroyed planets: {kvp.Value.Count}");
                    br1= 1;
                }
                foreach (var planet in kvp.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            if (!planets.ContainsKey("A")&&a==false)
            {
                Console.WriteLine($"Attacked planets: 0");
            }
            if (!planets.ContainsKey("D"))
            {
                Console.WriteLine($"Destroyed planets: 0");
            }
        }

        static string DecryptMessage(string encryptedMessage)
        {
            string decryptMessage=string.Empty;
            int decryptedStep=GetDecryptedStep(encryptedMessage);
            foreach (char ch in encryptedMessage)
            {
                decryptMessage += (char)(ch - decryptedStep);
            }
            return decryptMessage;
        }
        static int GetDecryptedStep(string encryptedMessage)
        {
            int br = 0;
            foreach (char ch in encryptedMessage.ToLower())
            {
                if(ch=='s'||ch=='t'||ch=='a'||ch=='r')
                {
                    br++;
                }
            }
            return br;
        }
    }
}
