using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsScore = new Dictionary<string, int>();
            var submisionLang = new Dictionary<string, int>();
            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] token = input.Split("-");
                if (token.Length == 3)
                {
                    string username = token[0];
                    string language = token[1];
                    int points = int.Parse(token[2]);
                    if (studentsScore.ContainsKey(username))
                    {
                        if (studentsScore[username] < points)
                        {
                            studentsScore[username] = points;
                        }
                    }
                    else
                    {
                        studentsScore.Add(username, points);
                    }
                    if (submisionLang.ContainsKey(language))
                    {
                        submisionLang[language]++;
                    }
                    else
                    {
                        submisionLang.Add(language, 1);
                    }
                }
                else if (token.Length == 2)
                {
                    string username = token[0];
                    if (studentsScore.ContainsKey(username))
                    {
                        studentsScore[username] = 0;
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var student in studentsScore.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Where(x=>x.Value>0))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var lang in submisionLang.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
