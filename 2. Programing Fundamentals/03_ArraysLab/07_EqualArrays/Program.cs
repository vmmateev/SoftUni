using System;
using System.Linq;

namespace _07_EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersCompare = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = true;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbersCompare[i])
                {
                    sum += numbers[i];
                }
                else
                {
                    isEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
                if (isEqual)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
        }
    }
}
