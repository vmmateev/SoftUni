using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < count; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(student))
                {
                    dict.Add(student, new List<double>() { grade });
                }
                else
                {
                    dict[student].Add(grade);
                }
            }
            foreach (var student in dict.OrderByDescending(x => x.Value.Average()).Where(x => x.Value.Average() > 4.49))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
