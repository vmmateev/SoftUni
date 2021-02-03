using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = new List<char>();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    result.Add(input[i]);
                }
            }
            result.Add(input[input.Length - 1]);
            Console.WriteLine(string.Join("", result));
                    }
    }
}
