using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestList = new Dictionary<string, string>();
            //username          Contest, points   
            var studentsList = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests") // spisyk na contest i paroli
            {
                if (input.Contains(":"))
                {
                    string contestName = input.Split(":", 2)[0];
                    string passwordContest = input.Split(":", 2)[1];
                    contestList.Add(contestName, passwordContest);
                }
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string contestName = input.Split("=>", 4)[0];
                string passContest = input.Split("=>", 4)[1];
                string username = input.Split("=>", 4)[2];
                int points = int.Parse(input.Split("=>", 4)[3]);

                if (contestList.ContainsKey(contestName) && contestList[contestName] == passContest) // Ako imeto na contesta i parolata sa verni 
                {
                    if (studentsList.ContainsKey(username)) // ako imame takav student
                    {
                        if (studentsList[username].ContainsKey(contestName)) // ako studenta ima takav contest
                        {
                            if (studentsList[username][contestName] < points) // ako izkaranite to4ki sa pove4e ot tezi do momenta
                            {
                                studentsList[username][contestName] = points; // zapisvame novite
                            }
                        }
                        else // ako studenta ne e polagal takav contest
                        {
                            studentsList[username].Add(contestName, points);
                        }
                    }
                    else // ako nqmame takav student
                    {
                        studentsList.Add(username, new Dictionary<string, int>()
                            {
                                { contestName , points }
                            });
                    }
                }
            }
            foreach (var student in studentsList.OrderByDescending(x=>x.Value.Values.Sum()).Take(1)) // Подреждаме речника в намалящ ред по стоиност(втория речник) и казваме х.ВторияРечник.Неговите Value-ta.Сумирай.ВземиПървата
            {
                Console.WriteLine($"Best candidate is {student.Key} with total {student.Value.Values.Sum()} points.");
            }
                        // Namira studenta s nai mnogo tochki
            //int currentSum = 0;
            //int maxSum = 0;
            //string bestStudent = string.Empty;
            //foreach (var student in studentsList)
            //{
            //    currentSum = 0;
            //    foreach (var contest in student.Value)
            //    {
            //        currentSum += contest.Value;
            //    }
            //    if (currentSum > maxSum)
            //    {
            //        maxSum = currentSum;
            //        bestStudent = student.Key;
            //    }
            //}
            //Console.WriteLine($"Best candidate is {bestStudent} with total {maxSum} points.");            
            Console.WriteLine("Ranking: ");
            foreach (var student in studentsList.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var contest in student.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
