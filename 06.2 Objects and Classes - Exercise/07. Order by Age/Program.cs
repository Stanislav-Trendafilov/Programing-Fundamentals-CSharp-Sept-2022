using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<People> people = new List<People>();
            while(input!="End")
            {
                string[] cmdArgs = input.Split(" ");
                string name = cmdArgs[0];
                int Id = int.Parse(cmdArgs[1]);
                int age= int.Parse(cmdArgs[2]);
                People person = new People(name, Id, age);
                people.Add(person);
               input = Console.ReadLine();
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    public class People
    {
        public People(string name, int iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public int ID{ get; set; }
        public int Age { get; set; }
    }
}
