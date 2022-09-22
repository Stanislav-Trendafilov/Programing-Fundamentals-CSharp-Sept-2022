using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int daysInMonth = 0;
            int capsulesCount = 0;
            double allSums=0;
            for(int i=1;i<=n;i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount= int.Parse(Console.ReadLine());
                double sum = ((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                allSums += sum;
            }
            Console.WriteLine($"Total: ${allSums:f2}");
        }
    }
}
