using System;

namespace _06_MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            Console.WriteLine(MiddleChars(first));
            
        }
        static string MiddleChars(string inputChars)
        {
            string result = "";
            char[] input = inputChars.ToCharArray();
            if (input.Length % 2 == 0)
            {
                string evenFirst = input[(input.Length / 2) - 1].ToString();
                string evenSecond = input[(input.Length / 2)].ToString();
                string even = string.Concat(evenFirst, evenSecond);
                result = even;
            }
            else
            {
                string odd = (input[input.Length / 2]).ToString();
                result = odd;
            }
            return result;
        }
    }
}
