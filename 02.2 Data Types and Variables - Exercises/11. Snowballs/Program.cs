using System;
using System.Numerics;
namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0,maxValue=0;
            int maxSnowballSnow = 0, maxSnowballTime = 0, maxSnowballQuality = 0;
            for (int i = 0; i < N; i++)
            {
                snowballValue = 0;
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime= int.Parse(Console.ReadLine());
                int snowballQuality= int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime) ,snowballQuality);
                if(snowballValue>maxValue)
                { maxValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxValue} ({maxSnowballQuality})");

        }
    }
}
