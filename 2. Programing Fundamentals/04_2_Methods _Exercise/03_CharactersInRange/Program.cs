using System;

namespace _03_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            Console.WriteLine(WriteCharLine(input1, input2));
        }

        static string WriteCharLine(char start, char end)
        {
            char temp;
            if (end <=start)
            {
                temp = start;
                start = end;
                end = temp;
            }
            string result = "";
            for (char i = (char)(start + 1); i < end; i++)
            {
                result += i + " ";
            }
            return result;
        }
    }
}
