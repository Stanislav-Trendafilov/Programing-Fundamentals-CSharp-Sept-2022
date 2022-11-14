using System;

namespace _01._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;
                bool isValidName = false;
                bool isValidAge = false;
                foreach (var letter in text)
                {
                    if (letter == '@'||isValidName==true)
                    {
                        isValidName = true;
                        if(letter!='|')
                        {
                            if (letter != '@')
                            {
                                name += letter;
                            }
                        }
                        else
                        {
                            isValidName = false;
                        }
                    }
                    else if (letter == '#' || isValidAge == true)
                    {
                        isValidAge = true;
                        if (letter != '*')
                       {
                            if (letter != '#')
                            {
                                age += letter;
                            }
                       }
                       else
                       {
                            isValidAge = false;
                       }
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");

            }
           
            
        }
    }
}
