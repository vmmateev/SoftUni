using System;

namespace _05_DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string chars = string.Empty;
            string other = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    chars += symbol;
                }
                else
                {
                    other += symbol;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(other);
        }
    }
}
