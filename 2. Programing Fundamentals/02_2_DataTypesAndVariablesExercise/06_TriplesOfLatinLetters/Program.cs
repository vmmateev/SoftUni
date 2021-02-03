using System;

namespace _06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char l = 'a'; l < 'a' + number; l++)
                    {
                        Console.WriteLine($"{i}{j}{l}");
                    }
                }
            }
        }
    }
}
