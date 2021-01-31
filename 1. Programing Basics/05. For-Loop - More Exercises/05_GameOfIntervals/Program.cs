using System;

namespace _05_GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double turns = double.Parse(Console.ReadLine());
            double number09 = 0;
            double number19 = 0;
            double number29 = 0;
            double number39 = 0;
            double number45 = 0;
            double invalidNumber = 0;
            double totalScore = 0;
            for (int i = 0; i < turns; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    number09++;
                    totalScore += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    number19++;
                    totalScore += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    number29++;
                    totalScore += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    number39++;
                    totalScore += 50;
                }

                else if (number >= 40 && number <= 50)
                {
                    number45++;
                    totalScore += 100;
                }
                else
                {
                    invalidNumber++;
                    totalScore /= 2;
                }
            }
            Console.WriteLine($"{totalScore:f2}");
            Console.WriteLine($"From 0 to 9: {number09 / turns * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {number19 / turns * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {number29 / turns * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {number39 / turns * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {number45 / turns * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumber / turns * 100:f2}%");
        }
    }
}
