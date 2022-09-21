using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int Students = int.Parse(Console.ReadLine());
            double priceLight= double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double sum = 0,brBelt=0;
            for (int i = 1; i <= Students; i++)
            {
                if(i%6==0)
                { brBelt++; }
              
            }
            sum = (priceLight + priceRobes + priceBelt) * Students + Math.Ceiling(0.1 * Students) * priceLight-  brBelt*priceBelt;
            if(sum<=money)
            { Console.WriteLine($"The money is enough - it would cost {sum:f2}lv."); }
            else
            { Console.WriteLine($"John will need {(sum-money):f2}lv more."); }
        }
    }
}
