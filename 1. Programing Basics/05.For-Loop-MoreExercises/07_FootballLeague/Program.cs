using System;

namespace _07_FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumSeats = double.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());
            double aCount = 0;
            double bCount = 0;
            double vCount = 0;
            double gCount = 0;
            for (int i = 0; i < fansCount; i++)
            {
                string fanSector = Console.ReadLine();
                if (fanSector == "A")
                {
                    aCount++;
                }
                else if (fanSector == "B")
                {
                    bCount++;
                }
                else if (fanSector == "V")
                {
                    vCount++;
                }
                else if (fanSector == "G")
                {
                    gCount++;
                }
            }
            Console.WriteLine($"{aCount/fansCount*100:f2}%");
            Console.WriteLine($"{bCount/fansCount*100:f2}%");
            Console.WriteLine($"{vCount/fansCount*100:f2}%");
            Console.WriteLine($"{gCount/fansCount*100:f2}%");
            Console.WriteLine($"{fansCount/stadiumSeats*100:f2}%");

        }
    }
}
