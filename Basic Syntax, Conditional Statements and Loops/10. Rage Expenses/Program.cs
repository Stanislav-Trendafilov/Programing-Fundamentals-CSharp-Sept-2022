using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = lostGames / 2;
            int mouseCount = lostGames /3;
            int keybordCount = lostGames / 6;
            int displayCount = lostGames / 12;
            double expenses = (headsetPrice * headsetCount) + (mousePrice * mouseCount) + (keybordPrice * keybordCount) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
