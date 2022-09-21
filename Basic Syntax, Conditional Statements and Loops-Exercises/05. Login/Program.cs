using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = string.Empty, reversedUser = string.Empty;
            for (int i = user.Length; i > 0; i--)
            {
                reversedUser += user[i - 1];
            }
            for (int i = 1; i <= 4; i++)
            {
                pass = Console.ReadLine();
                if (pass == reversedUser)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    if (i == 4)
                    {
                        Console.WriteLine($"User { user} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
        }
    }
}
