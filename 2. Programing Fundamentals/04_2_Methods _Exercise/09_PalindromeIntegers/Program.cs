using System;
using System.Diagnostics.Tracing;

namespace _09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static string isPalindrome(string input)
        {
            int counter = 0;
            string result = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    counter++;
                }
            }
            if (input.Length / 2 == counter)
            {
                result = "true";
            }
            else
            {
                result = "false";
            }
            return result;
        }
    }
}
