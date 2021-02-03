using System;

namespace _02_RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int k = 0; k < input[i].Length; k++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
