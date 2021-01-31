using System;

namespace _05_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string sleepPlace = "";
            double priceTrip = 0;
            if (budget <= 1000)
            {
                sleepPlace = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    priceTrip = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    priceTrip = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                sleepPlace = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    priceTrip = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    priceTrip = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                sleepPlace = "Hotel";
                priceTrip = budget * 0.9;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {sleepPlace} - {priceTrip:f2}");
        }
    }
}
