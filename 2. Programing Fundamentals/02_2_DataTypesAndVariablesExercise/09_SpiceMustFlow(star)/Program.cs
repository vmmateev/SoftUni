using System;

namespace _09_SpiceMustFlow_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int workersConsume = 26;
            int totalSpice = 0;
            while (startingYield >= 100)
            {
                days++;
                totalSpice += startingYield;
                totalSpice -= workersConsume;
                startingYield -= 10;
            }
            totalSpice -= workersConsume;
            if (totalSpice < 0)
            {
                totalSpice = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
