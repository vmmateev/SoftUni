using System;
using System.Linq;

namespace _05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBigger = true;
                for (int k = 1 + i; k < numbers.Length; k++)
                {
                    if (numbers[i] <= numbers[k])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write(numbers[i]+" ");
                }
            }
        }
    }
}
