using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string user = input[1];
                
                if(command=="register")
                {
                    string plate = input[2];
                    if (!users.ContainsKey(user))
                    {
                        users[user] = plate;
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[user]}");
                    }
                }
                else
                {
                    if (!users.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        users.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }

                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
