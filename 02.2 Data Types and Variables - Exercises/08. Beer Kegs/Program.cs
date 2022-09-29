using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nameKeg = string.Empty;
            double biggestVolume = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float r = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(r, 2) * height;
                if(volume>biggestVolume)
                { biggestVolume = volume;
                    nameKeg = model;
                }
            }
            Console.WriteLine(nameKeg);
        }
    }
}
