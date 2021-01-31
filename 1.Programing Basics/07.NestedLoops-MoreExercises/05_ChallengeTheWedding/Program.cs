using System;

namespace _05_ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int manCount = int.Parse(Console.ReadLine());
            int womanCount = int.Parse(Console.ReadLine());
            int tableCount = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int man = 1; man <= manCount; man++)
            {
                for (int woman = 1; woman <= womanCount; woman++)
                {
                    if (counter <= tableCount)
                    {
                        Console.Write($"({man} <-> {woman}) ");
                    }
                    counter++;
                }
            }
        }
    }
}
