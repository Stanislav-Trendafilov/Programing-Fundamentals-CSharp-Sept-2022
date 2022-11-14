using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i = 0;
            while(input!= "end of comments")
            {
                if(i==0)
                {
                    Console.WriteLine("<h1>");
                    Console.WriteLine($"    {input}");
                    Console.WriteLine("</h1>");
                }
                else if(i==1)
                {
                    Console.WriteLine("<article>");
                    Console.WriteLine($"    {input}");
                    Console.WriteLine("</article>");
                }
                else
                {
                    Console.WriteLine("<div>");
                    Console.WriteLine($"    {input}");
                    Console.WriteLine("</div>");
                }
                i++;
                input = Console.ReadLine();
            }
        }
    }
}
