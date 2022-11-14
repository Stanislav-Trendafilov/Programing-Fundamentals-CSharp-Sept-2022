using System;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string sentence = string.Empty;
            foreach (var letter in input)
            {
                switch (letter)
                {
                    case ".-":
                        sentence += 'A';
                        break;
                    case "-...":
                        sentence += 'B';
                        break;
                    case "-.-.":
                        sentence += 'C';
                        break;
                    case "-..":
                        sentence += 'D';
                        break;
                    case ".":
                        sentence += 'E';
                        break;
                    case "..-.":
                        sentence += 'F';
                        break;
                    case "--.":
                        sentence += 'G';
                        break;
                    case "....":
                        sentence += 'H';
                        break;
                    case "..":
                        sentence += 'I';
                        break;
                    case ".---":
                        sentence += 'J';
                        break;
                    case "-.-":
                        sentence += 'K';
                        break;
                    case ".-..":
                        sentence += 'L';
                        break;
                    case "--":
                        sentence += 'M';
                        break;
                    case "-.":
                        sentence += 'N';
                        break;
                    case "---":
                        sentence += 'O';
                        break;
                    case ".--.":
                        sentence += 'P';
                        break;
                    case "--.-":
                        sentence += 'Q';
                        break;
                    case ".-.":
                        sentence += 'R';
                        break;
                    case "...":
                        sentence += 'S';
                        break;
                    case "-":
                        sentence += 'T';
                        break;
                    case "..-":
                        sentence += 'U';
                        break;
                    case "...-":
                        sentence += 'V';
                        break;
                    case ".--":
                        sentence += 'W';
                        break;
                    case "-..-":
                        sentence += 'X';
                        break;
                    case "-.--":
                        sentence += 'Y';
                        break;
                    case "--..":
                        sentence += 'Z';
                        break;
                    default:
                        sentence += ' ';
                        break;
                }
            }
            Console.WriteLine(sentence);
        }
    }
}
                         