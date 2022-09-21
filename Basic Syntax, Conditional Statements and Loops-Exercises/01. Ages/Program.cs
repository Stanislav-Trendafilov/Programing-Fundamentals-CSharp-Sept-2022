using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            if (ages >= 0 && ages <= 2)
            { Console.WriteLine("baby"); }
            else if (ages >= 3 && ages <= 13)
            { Console.WriteLine("child"); }
            else if (ages >= 14 && ages <= 19)
            { Console.WriteLine("teenager"); }
            else if (ages >= 20 && ages <= 65)
            { Console.WriteLine("adult"); }
            else
            { Console.WriteLine("elder"); }
            /*•	0-2 – baby
•	3-13 – child
•	14-19 – teenager
•	20-65 – adult
•	>= 66 – elder
•	All the values are inclusive.

             
             */
        }
    }
}

