using System;

namespace _08_FactorielDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double firstFact = FactorialResult(first);
            double secondFact = FactorialResult(second);
            double divisionResult = firstFact / secondFact;
            Console.WriteLine($"{divisionResult:f2}");
        }

        static double FactorialResult(int input)
        {
            double result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
