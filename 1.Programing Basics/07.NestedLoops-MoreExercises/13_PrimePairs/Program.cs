using System;

namespace _13_PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStart = int.Parse(Console.ReadLine());
            int firstDiff = int.Parse(Console.ReadLine());
            int secondDiff = int.Parse(Console.ReadLine());

            for (int i = firstPairStart; i <= firstPairStart + firstDiff; i++)
            {
                for (int k = secondPairStart; k <= secondPairStart + secondDiff; k++)
                {
                    bool firstIsPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            firstIsPrime = false;
                        }
                    }
                    bool secondIsPrime = true;
                    for (int l = 2; l <= Math.Sqrt(k); l++)
                    {
                        if (k % l == 0)
                        {
                            secondIsPrime = false;
                        }
                    }
                    if (firstIsPrime && secondIsPrime)
                    {
                        Console.WriteLine($"{i}{k}");
                    }
                }
            }
        }
    }
}
