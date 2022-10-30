using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (input!="end")
            {
                string[] personInfo = input.Split();
                Student student = new Student();
                student.FirstName = personInfo[0];
                student.LastName = personInfo[1];
                student.Age = int.Parse(personInfo[2]);
                student.Hometown = personInfo[3];

                students.Add(student);
                input = Console.ReadLine();
            }
            string deservedHometown = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Hometown==deservedHometown)
                {
                    Console.WriteLine($"{ students[i].FirstName} {students[i].LastName} is { students[i].Age } years old.");
                }
            }
        }
    }
    public class Student
    {
        //public Student(string name,string lname,int age,string hometown)
        //{
        //    FirstName=name;
        //    LastName= lname ;
        //    Age=age;
        //    Hometown=hometown;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown{ get; set; }


    }
}
