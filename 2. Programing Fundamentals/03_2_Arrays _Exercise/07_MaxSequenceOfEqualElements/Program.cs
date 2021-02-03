using System;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = 0;
            int topLenght = 0;
            int indexValue = 1;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    lenght++;
                    if (lenght > topLenght)
                    {
                        topLenght = lenght;
                        indexValue = numbers[i];
                    }
                }
                else
                {
                    lenght = 0;
                }
            }
            for (int i = 0; i <= topLenght; i++)
            {
                Console.Write(indexValue + " ");
            }
        }
    }
}
