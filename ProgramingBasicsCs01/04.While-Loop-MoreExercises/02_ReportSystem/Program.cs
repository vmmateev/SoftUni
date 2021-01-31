using System;

namespace _02_ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double donationSum = double.Parse(Console.ReadLine());
            int counter = 1;
            string command = Console.ReadLine();
            double posCounter = 0;
            double posSum = 0;
            double cacheCounter = 0;
            double cacheSum = 0;
            double expectedSum = 0;
            while (command != "End")
            {
                double productPrice = double.Parse(command);
                if (counter % 2 == 0 && productPrice < 10)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else if (counter % 2 != 0 && productPrice > 100)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    expectedSum += productPrice;
                    Console.WriteLine("Product sold!");
                    if (counter % 2 == 0)
                    {
                        posCounter++;
                        posSum += productPrice;
                    }
                    else if (counter % 2 != 0)
                    {
                        cacheCounter++;
                        cacheSum += productPrice;
                    }
                }
                if (expectedSum >= donationSum)
                {
                    Console.WriteLine($"Average CS: {cacheSum / cacheCounter:f2}");
                    Console.WriteLine($"Average CC: {posSum / posCounter:f2}");
                    break;
                }
                counter++;
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
