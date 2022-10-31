using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] phrases = new string[6] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = new string[6] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] names = new string[8] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[5] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int ind1 = random.Next(0, 6);
                int ind2 = random.Next(0, 6);
                int ind3 = random.Next(0, 8);
                int ind4 = random.Next(0, 5);
                Console.WriteLine($"{phrases[ind1]} {events[ind2]} {names[ind3]} – {cities[ind4]}.");
            }
        }
    }
}
