using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02_Judge
{
    class Program
    {
        static void Main(string[] args)
        {                               // contest  //student        //points
            var studentExam = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string username = input.Split(" -> ", 3)[0];
                string contest = input.Split(" -> ", 3)[1];
                int points = int.Parse(input.Split(" -> ", 3)[2]);

                if (studentExam.ContainsKey(contest)) //ako ima takov contest
                {
                    if (studentExam[contest].ContainsKey(username)) // ako ima takav student
                    {
                        if (studentExam[contest][username] < points) // ako e izkaral po dobar rezultat
                        {
                            studentExam[contest][username] = points;
                        }
                    }
                    else
                    {
                        studentExam[contest].Add(username, points);
                    }
                }
                else
                {
                    studentExam.Add(contest, new Dictionary<string, int>() { { username, points } });
                }
            }
            int position = 1;
            foreach (var contest in studentExam)
            {
                position = 1;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                foreach (var student in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {student.Key} <::> {student.Value}");
                    position++;
                }
            }
            var topRankDict = new Dictionary<string, int>();
                                    // contest //student //points
            foreach (var item in studentExam)
            {
                foreach (var students in item.Value) // Итем.Валуе е вложения речник а студент.кей е името на студента студент.валуе точките на студента
                {
                    if (!topRankDict.ContainsKey(students.Key)) // ако новия ни речник не съдържа името на студента от вложения речник го добаваме заедно с точките му 
                    {
                        topRankDict.Add(students.Key, students.Value);
                    }
                    else                                        // ако студента се съдържа добавяме точките му от другите контести към съществуващите
                    {
                        topRankDict[students.Key] += students.Value;
                    }
                }
            }
            Console.WriteLine("Individual standings:");
                position = 1;
            foreach (var kvp in topRankDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position}. {kvp.Key} -> {kvp.Value}");
                position++;
            }
        }
    }
}
