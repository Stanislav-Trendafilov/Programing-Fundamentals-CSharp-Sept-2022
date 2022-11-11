using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
           double suma = 0,number=0;
            for (int i = 0; i < words.Length; i++)
            {
                string currentword = words[i];
                number = double.Parse(currentword.Substring(1, currentword.Length - 2).ToString());
                if(char.IsUpper(currentword[0]))
                {
                    number = number / ((int)currentword[0] - 64);
                }
                else
                {
                    number = number * ((int)currentword[0] - 96);
                }

                if(char.IsUpper(currentword[currentword.Length-1]))
                {
                    number = number - ((int)currentword[currentword.Length - 1] - 64);
                }
                else
                {
                    number = number + ((int)currentword[currentword.Length - 1] - 96);
                }
                suma += number;
            }
            Console.WriteLine($"{suma:f2}");
        }
    }
}
