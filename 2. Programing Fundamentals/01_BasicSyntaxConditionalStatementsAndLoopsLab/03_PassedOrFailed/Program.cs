using System;

namespace _03_PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }
            else if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
