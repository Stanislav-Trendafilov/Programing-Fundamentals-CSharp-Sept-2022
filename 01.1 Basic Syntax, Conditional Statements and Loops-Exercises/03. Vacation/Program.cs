using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;
            if (group == "Students")
            {
                if (day == "Friday")
                { sum = people * 8.45; }
                else if (day == "Saturday")
                { sum = people * 9.80; }
                else if (day == "Sunday")
                { sum = people * 10.46; }
                if (people >= 30)
                { sum = sum - 0.15 * sum; }
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    sum = people * 10.90;
                    if (people >= 100)
                    { sum = sum - 10 * 10.90; }
                }
                else if (day == "Saturday")
                {
                    sum = people * 15.60;
                    if (people >= 100)
                    { sum = sum - 10 * 15.60; }
                }
                else if (day == "Sunday")
                {
                    sum = people * 16.0;
                    if (people >= 100)
                    { sum = sum - 10 * 16.0; }
                }

            }
            else if (group == "Regular")
            {
                if (day == "Friday")
                { sum = people * 15.0; }
                else if (day == "Saturday")
                { sum = people * 20.0; }
                else if (day == "Sunday")
                { sum = people * 22.50; }
                if (people >= 10 && people <= 20)
                { sum = sum - 0.05 * sum; }
            }
            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}
