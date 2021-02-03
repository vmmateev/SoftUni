using System;

namespace _07_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFills = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            for (int i = 0; i < numberOfFills; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (totalLiters + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {

                    totalLiters += liters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
