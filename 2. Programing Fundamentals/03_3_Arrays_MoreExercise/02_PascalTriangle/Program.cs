using System;

namespace _02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            if (numOfRows == 1)
            {
                return;
            }
            int[] baseArray = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", baseArray));
            if (numOfRows == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < baseArray.Length + 1; i++)
                {
                    int[] advancedArray = new int[baseArray.Length + 1];
                    advancedArray[0] = 1;
                    advancedArray[advancedArray.Length - 1] = 1;
                    for (int j = 1; j < advancedArray.Length - 1; j++)
                    {
                        advancedArray[j] = baseArray[j - 1] + baseArray[j];
                    }
                    Console.WriteLine(string.Join(" ", advancedArray));
                    baseArray = advancedArray;
                    if (baseArray.Length == numOfRows)
                    {
                        break;
                    }
                }
            }
        }
    }
}
