using System;

namespace _02_BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double totalSum = 0;
            double discount = 1;
            if (juniors + seniors >= 50 && trace == "cross-country")
            {
                discount = 0.75;
            }

            if (trace == "trail")
            {
                totalSum = ((5.5 * juniors) + (7 * seniors)) * discount;
            }
            else if (trace == "cross-country")
            {
                totalSum = ((8 * juniors) + (9.5 * seniors)) * discount;
            }
            else if (trace == "downhill")
            {
                totalSum = ((12.25 * juniors) + (13.75 * seniors)) * discount;
            }
            else if (trace == "road")
            {
                totalSum = ((20 * juniors) + (21.5 * seniors)) * discount;
            }
            totalSum -= totalSum * 0.05;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
