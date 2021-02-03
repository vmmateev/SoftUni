using System;

namespace _04_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string outputReversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                outputReversed += input[i];
            }
            Console.WriteLine(outputReversed);
        }
    }
}
