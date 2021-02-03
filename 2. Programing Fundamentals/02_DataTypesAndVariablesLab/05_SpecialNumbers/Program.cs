using System;

namespace _05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int num1 = i;
                int num2 = 0;
                if (num1 > 9)
                {
                    num2 = num1 % 10;
                    num1 = i / 10;
                }
                bool isSpecial = num1 + num2 == 5 || num1 + num2 == 7 || num1 + num2 == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
