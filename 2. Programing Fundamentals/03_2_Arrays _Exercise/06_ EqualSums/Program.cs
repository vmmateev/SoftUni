using System;
using System.Linq;

namespace _06__EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            bool isEqual = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }

                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    index = i;

                }
            }
                if (isEqual)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
        }
    }
}