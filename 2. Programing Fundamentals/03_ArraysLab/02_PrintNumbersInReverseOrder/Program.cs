using System;

namespace _02_PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            int[] reverseNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                reverseNumbers[n - i - 1] = numbers[i];
            }
            for (int i = 0; i < reverseNumbers.Length; i++)
            {
                Console.Write($"{reverseNumbers[i]} ");
            }
        }
    }
}
