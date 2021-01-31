using System;

namespace _04_CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "";
            string carType = "";
            double carPrice = 0;
            if (budget <= 100)
            {
                carClass = "Economy class";

                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = 0.35 * budget;
                        break;

                    case "Winter":
                        carType = "Jeep";
                        carPrice = 0.65 * budget;
                        break;
                }
            }

            else if (budget >= 100 && budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        carType = "Cabrio";
                        carPrice = 0.45 * budget;
                        break;

                    case "Winter":
                        carType = "Jeep";
                        carPrice = 0.8 * budget;
                        break;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carPrice = 0.9 * budget;
                carType = "Jeep";
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
