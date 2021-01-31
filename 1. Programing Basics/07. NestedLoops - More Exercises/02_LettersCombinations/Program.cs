using System;

namespace _02_LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char notPrint = char.Parse(Console.ReadLine());
            double counter = 0;
            for (char i = begin; i <= end; i++)
            {
                for (char j = begin; j <= end; j++)
                {
                    for (char k = begin; k <= end; k++)
                    {
                        if (k != notPrint && i != notPrint && j != notPrint)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
