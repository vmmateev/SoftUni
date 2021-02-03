using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var students = new List<Student>();
            while ((input= Console.ReadLine())!="end")
            {
                string[] tokens = input.Split();
                var student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                students.Add(student);
            }
            string search = Console.ReadLine();
            var filterStudents = students.FindAll(x => x.HomeTown == search);
            foreach (var student in filterStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    public class Student
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown{ get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
