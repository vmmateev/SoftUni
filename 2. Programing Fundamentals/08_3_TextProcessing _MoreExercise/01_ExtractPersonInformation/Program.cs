using System;

namespace _01_ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int firstIndex = input.IndexOf('@');
                int lastIndex = input.IndexOf('|');
                int length = lastIndex - firstIndex-1;
                string name = input.Substring(firstIndex+1, length);

                int ageIndexBegin = input.IndexOf('#');
                int ageIndexEnd = input.IndexOf('*');
                int ageLength = ageIndexEnd - ageIndexBegin-1;
                string age = input.Substring(ageIndexBegin+1, ageLength);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
