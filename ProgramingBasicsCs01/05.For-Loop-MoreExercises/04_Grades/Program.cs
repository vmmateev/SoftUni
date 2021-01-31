using System;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double grade22 = 0;
            double grade33 = 0;
            double grade44 = 0;
            double grade56 = 0;
            double gradeSum = 0;
            for (int i = 0; i < studentCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2 && grade <= 2.99)
                {
                    grade22++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    grade33++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    grade44++;
                }
                else if (grade >= 5 && grade <= 6)
                {
                    grade56++;
                }
                gradeSum += grade;
            }
            double topStudents = grade56 / studentCount * 100;
            double fourStudents = grade44 / studentCount * 100;
            double threeStudents = grade33 / studentCount * 100;
            double twoStudents = grade22 / studentCount * 100;
            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeStudents:f2}%");
            Console.WriteLine($"Fail: {twoStudents:f2}%");
            Console.WriteLine($"Average: {gradeSum / studentCount:f2}");
        }
    }
}
