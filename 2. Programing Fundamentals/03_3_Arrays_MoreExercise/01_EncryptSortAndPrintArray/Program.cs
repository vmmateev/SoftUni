using System;
using System.Linq;

namespace _01_EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings = int.Parse(Console.ReadLine());
            int[] namesToNums = new int[numberStrings];
            int sumOfChars = 0;
            string vowels = "aAeEiIoOuU";
            for (int i = 0; i < numberStrings; i++)
            {
                string names = Console.ReadLine();
                sumOfChars = 0;
                for (int j = 0; j < names.Length; j++)
                {
                    if (vowels.Contains(names[j]))
                    {
                        sumOfChars += names[j] * names.Length;
                    }
                    else
                    {
                        sumOfChars += names[j] / names.Length;
                    }
                    namesToNums[i] = sumOfChars;
                }
            }
                Array.Sort(namesToNums);
            foreach (var num in namesToNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
