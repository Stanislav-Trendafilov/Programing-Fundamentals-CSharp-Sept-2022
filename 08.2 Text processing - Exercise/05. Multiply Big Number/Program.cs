using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numb = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            int reminder = 0;
            if(input=="0"||numb==0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());
                int product = numb * currentDigit + reminder;
                reminder = product / 10;
                product=product% 10;
                output.Insert(0,product);
            }
            if(reminder>0)
            {
                output.Insert(0, reminder);
            }
            Console.WriteLine(output);
        }
    }
}
