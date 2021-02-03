using System;

namespace _10_Pokemon_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());   // N
            int distance = int.Parse(Console.ReadLine());    // M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y
            double halfPokePower = pokePower * 0.5;
            int poke = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                if (pokePower == halfPokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
                poke++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(poke);
        }
    }
}
