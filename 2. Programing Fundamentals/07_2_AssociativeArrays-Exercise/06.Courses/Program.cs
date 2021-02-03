using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesDict = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(" : ");
                string courseName = data[0];
                string studentName = data[1];
                if (!coursesDict.ContainsKey(courseName))
                {
                    coursesDict.Add(courseName, new List<string>() { studentName });
                }
                else
                {
                    coursesDict[courseName].Add(studentName);
                }
            }
            foreach (var course in coursesDict.OrderByDescending(x => x.Value.Count)) //За да достъпиш Лист от речник може с вложен foreach както е показано със сортировка
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
