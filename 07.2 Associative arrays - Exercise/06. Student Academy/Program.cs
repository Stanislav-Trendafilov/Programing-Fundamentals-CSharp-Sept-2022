using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(!students.ContainsKey(name))
                {
                    students.Add(name, grade);
                }
                else
                {
                    students[name] = (students[name] + grade) / 2;
                }
            }
            foreach (var student in students.Where(x=>x.Value>=4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
