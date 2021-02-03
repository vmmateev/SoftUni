using System;

namespace _04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] += (char)3;
            }
            Console.WriteLine(input);
        }
    }
}
