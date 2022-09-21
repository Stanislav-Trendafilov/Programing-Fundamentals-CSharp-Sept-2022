using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sum = 0;
            while(input!="Start")
            {
                input = Console.ReadLine();
                if(input=="Start")
                { break; }
                double money = double.Parse(input);
                if(money!=0.1&&money!=0.2&&money!=0.5&&money!=1&&money!=2)
                {
                    Console.WriteLine($"Cannot accept {money}");
                    break; 
                }
                sum += money;
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                if(input== "Nuts")
                {
                    if(sum>=2)
                    { Console.WriteLine("Purchased nuts"); sum -= 2; }
                    else
                    { Console.WriteLine("Sorry, not enough money"); }
                    
                }
                else if (input == "Water")
                {
                    if (sum >= 0.7)
                    { Console.WriteLine("Purchased water"); sum -= 0.7; }
                    else
                    { Console.WriteLine("Sorry, not enough money"); }
                    
                }
                else if (input == "Crisps")
                {
                    if (sum >= 1.5)
                    { Console.WriteLine("Purchased crisps"); sum -= 1.5; }
                    else
                    { Console.WriteLine("Sorry, not enough money"); }
                  
                }
                else if (input == "Soda")
                {
                    if (sum >= 0.8)
                    { Console.WriteLine("Purchased soda"); sum -= 0.8; }
                    else
                    { Console.WriteLine("Sorry, not enough money"); }
                  
                }
                else if (input == "Coke")
                {
                    if (sum >= 1.0)
                    { Console.WriteLine("Purchased coke"); sum -= 1.0; }
                    else
                    { Console.WriteLine("Sorry, not enough money"); }
                   
                }
                else
                { Console.WriteLine("Invalid product"); }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
