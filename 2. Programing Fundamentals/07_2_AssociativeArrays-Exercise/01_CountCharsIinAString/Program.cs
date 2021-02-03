using System;
using System.Collections.Generic;

namespace _01_CountCharsIinAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> counterChars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                if (counterChars.ContainsKey(input[i]))
                {
                    counterChars[input[i]]++;
                }
                else
                {
                    counterChars.Add(input[i], 1);
                }
            }
            foreach (var symbol in counterChars)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
