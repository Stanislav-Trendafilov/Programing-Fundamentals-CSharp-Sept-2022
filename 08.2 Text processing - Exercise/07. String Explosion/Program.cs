using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(bomb>0&&text[i]!='>')
                {
                    text=text.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if(text[i]=='>')
                {
                    bomb += int.Parse(text[i + 1].ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
