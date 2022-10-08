using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int br = 0;

            if (passwordLength(password))
            { br++; }
            else
            { Console.WriteLine("Password must be between 6 and 10 characters"); }

            if (passwordContain(password))
            { br++; }
            else
            { Console.WriteLine("Password must consist only of letters and digits"); }
         
            if (passwordDigits(password))
            {br++;}
            else
            { Console.WriteLine("Password must have at least 2 digits"); }


            if(br==3)
            { Console.WriteLine("Password is valid"); }
        }
       static bool passwordLength(string a)
       {
           if(a.Length>=6&&a.Length<=10)
           { return true; }
            return false; 
       }
        static bool passwordContain(string a)
        {
          
            foreach (char letter in a)
            {
                if(!(   ((int)letter>=48&&(int)letter<=57)  ||   ((int)letter >= 65 && (int)letter <= 90) || ((int)letter >= 97 && (int)letter <= 122) ))
                { return false; }
            }
            return true;

        }
        static bool passwordDigits(string a)
        {
            int br = 0;
            foreach (char letter in a)
            {
                if (((int)letter >= 48 && (int)letter <= 57))
                { br++; }

            }
            if (br >= 2)
            { return true; }
             return false; 

        }
    }
}
