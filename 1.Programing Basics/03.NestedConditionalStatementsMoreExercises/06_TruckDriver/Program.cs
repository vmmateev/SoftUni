using System;

namespace _06_TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double taxes = 0.9;
            double payPerKm = 0;

            if (distance <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    payPerKm = 0.75;
                }
                else if (season == "Summer")
                {
                    payPerKm = 0.9;
                }
                else if (season == "Winter")
                {
                    payPerKm = 1.05;
                }
            }
            else if (distance > 5000 && distance <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    payPerKm = 0.95;
                }
                else if (season == "Summer")
                {
                    payPerKm = 1.1;
                }
                else if (season == "Winter")
                {
                    payPerKm = 1.25;
                }
            }
            else if (distance > 10000 && distance <= 20000)
            {
                payPerKm = 1.45;
            }

            double totalSalary = ((distance * 4) * payPerKm) * taxes;
            Console.WriteLine($"{totalSalary:f2}");
        }
    }
}
