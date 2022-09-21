using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balanceFirstly = double.Parse(Console.ReadLine());
            double balance = balanceFirstly;
            string input = Console.ReadLine(); ;
            bool flag = true;
            while(input!= "Game Time")
            {
                
                if (input== "OutFall 4")
                { 
                    if(balance>= 39.99)
                    { 
                        Console.WriteLine($"Bought OutFall 4");
                        balance -= 39.99;
                    }
                     else
                    { Console.WriteLine("Too Expensive"); }
                }
                else if (input == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        Console.WriteLine($"Bought CS: OG");
                        balance -= 15.99;
                    }
                    else
                    { Console.WriteLine("Too Expensive"); }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        Console.WriteLine($"Bought Zplinter Zell");
                        balance -= 19.99;
                    }
                    else
                    { Console.WriteLine("Too Expensive"); }
                }
                else if (input == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        Console.WriteLine($"Bought Honored 2");
                        balance -= 59.99;
                    }
                    else
                    { Console.WriteLine("Too Expensive"); }
                }
                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        Console.WriteLine($"Bought RoverWatch");
                        balance -= 29.99;
                    }
                    else
                    { Console.WriteLine("Too Expensive"); }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99)
                    {
                        Console.WriteLine($"Bought RoverWatch Origins Edition");
                        balance -= 39.99;
                    }
                    else
                    { Console.WriteLine("Too Expensive"); }
                }
                else { Console.WriteLine("Not Found"); }
               
                if (balance == 0.00)
                { 
                    Console.WriteLine("Out of money!");
                    break;
                    flag = false;
                }
                input = Console.ReadLine();
            }
            if (flag)
            {
                Console.WriteLine($"Total spent: ${(balanceFirstly-balance):f2}. Remaining: ${balance:f2}");
            }

        }
    }
}
