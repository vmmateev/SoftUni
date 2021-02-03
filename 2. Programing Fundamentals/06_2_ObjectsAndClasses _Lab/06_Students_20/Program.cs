using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06_Students_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                var student = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                StudentExistOrNot(students, tokens, student);
            }
            string search = Console.ReadLine();
            var filterStudents = students.FindAll(x => x.HomeTown == search);
            foreach (var student in filterStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void StudentExistOrNot(List<Student> students, string[] tokens, Student student)
        {
            if (students.Any(x => x.FirstName == tokens[0] && x.LastName == tokens[1]))
            {
                var objToDelete = students.Find((x => x.FirstName == tokens[0] && x.LastName == tokens[1]));
                students.Remove(objToDelete);
                students.Add(student);
            }

            else
            {
                students.Add(student);
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

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

