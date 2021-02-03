using System;

namespace _01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string output = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    output += (input[input.Length - 1 - i]);
                }
                Console.WriteLine($"{input} = {output}");
            }
        }
    }
}
