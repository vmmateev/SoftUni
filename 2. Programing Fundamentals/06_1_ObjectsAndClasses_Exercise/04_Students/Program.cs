using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countStudents; i++)
            {
            var input = Console.ReadLine().Split().ToList();

                string firstname = input[0];
                string lastname = input[1];
                double grade = double.Parse(input[2]);
                var student = new Student(firstname, lastname, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
                        Console.WriteLine(string.Join(Environment.NewLine,students));

            
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstname, string lastname, double grade)
            {
                FirstName = firstname;
                LastName = lastname;
                Grade = grade;
            }
            public Student() // overload на метода така че да се поддържат и двата варианта на създаване на обекти и с готови стойност всички на брой и без стойности с отделно присвояване
            {
                
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
