using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (palindrome(input))
                { Console.WriteLine("true"); }
                else
                { Console.WriteLine("false"); }
                input = Console.ReadLine();
            }

        }

        private static bool palindrome(string input)
        {
            bool flag = true ;
            for (int i = 0; i < input.Length/2; i++)
            {
                if(input[i]==input[input.Length-1-i])
                { 
                    flag= true; 
                }
                else
                { 
                    flag=false;
                    break;
                }
            }
            return flag; 
        }
    }
}
