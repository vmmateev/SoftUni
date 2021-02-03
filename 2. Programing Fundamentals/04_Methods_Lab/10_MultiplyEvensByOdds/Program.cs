using System;
using System.Xml;

namespace _10_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleEvenOdds(number));
        }

        static int GetSumOfEven(int num)
        {
            int result = 0;
            while (num != 0)
            {
                int numberToCheck = num % 10;
                if (numberToCheck % 2 == 0)
                {
                    result += numberToCheck;
                }
                num /= 10;
            }
            return Math.Abs(result);
        }
        static int GetSumOfOdd(int num)
        {
            int result = 0;
            while (num != 0)
            {
                int numberToCheck = num % 10;
                if (numberToCheck % 2 != 0)
                {
                    result += numberToCheck;
                }
                num /= 10;
            }
            return Math.Abs(result);
        }

        static int GetMultipleEvenOdds(int input)
        {
            int result = GetSumOfEven(input) * GetSumOfOdd(input);

            return result;
        }
    }
}
