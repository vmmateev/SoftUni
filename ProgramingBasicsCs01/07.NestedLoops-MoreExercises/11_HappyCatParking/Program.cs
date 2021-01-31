using System;

namespace _11_HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursForDay = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double daySum = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int k = 1; k <= hoursForDay; k++)
                {
                    if (i % 2 == 0 && k % 2 != 0)
                    {
                        totalSum += 2.5;
                        daySum += 2.5;
                    }
                    else if (i % 2 != 0 && k % 2 == 0)
                    {
                        totalSum += 1.25;
                        daySum += 1.25;
                    }
                    else
                    {
                        totalSum += 1;
                        daySum += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {daySum:f2} leva");
                daySum = 0;
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
