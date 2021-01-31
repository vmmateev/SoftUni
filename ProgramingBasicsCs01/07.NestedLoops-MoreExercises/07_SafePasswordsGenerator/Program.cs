using System;

namespace _07_SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int xEnd = int.Parse(Console.ReadLine());
            int yEnd = int.Parse(Console.ReadLine());
            int maxGenPass = int.Parse(Console.ReadLine());
            char firstSymbol = '#';
            char SecondSymbol = '@';
            int generatedPass = 1;

            for (int j = 1; j <= xEnd; j++)
            {
                for (int k = 1; k <= yEnd; k++)
                {
                    Console.Write($"{firstSymbol}{SecondSymbol}{j}{k}{SecondSymbol}{firstSymbol}|");
                    firstSymbol++;
                    SecondSymbol++;
                    if (firstSymbol > '7')
                    {
                        firstSymbol = '#';
                    }
                    if (SecondSymbol > '`')
                    {
                        SecondSymbol = '@';
                    }
                    generatedPass++;

                    if (generatedPass > maxGenPass)
                    {
                        return;
                    }
                }
            }
        }
    }
}
