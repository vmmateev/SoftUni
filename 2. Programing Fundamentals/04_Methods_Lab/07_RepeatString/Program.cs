using System;

namespace _07_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string output = RepeatString(input, count);
            Console.WriteLine(output);
                
        }
        static string RepeatString (string input, int counter)
        {
            string result = "";
            for (int i = 0; i < counter; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
