using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input!="end")
            {
                string[] cmdArg = input.Split(" : ");
                string course = cmdArg[0];
                string user = cmdArg[1];
                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }
                courses[course].Add(user);
                input = Console.ReadLine(); 
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var user in course.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
