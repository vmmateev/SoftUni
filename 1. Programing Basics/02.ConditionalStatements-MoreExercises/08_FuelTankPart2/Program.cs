using System;

namespace _08_FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            string cardFuel = Console.ReadLine();
            double discount = 1;
            double totalFuel = 0;

            double dieselPrice = 2.33;
            double gasolinePrice = 2.22;
            double gasPrice = 0.93;

            if (cardFuel == "Yes")
            {
                dieselPrice = 2.21;
                gasolinePrice = 2.04;
                gasPrice = 0.85;
            }
            if (fuel >= 20 && fuel <= 25)
            {
                discount = 0.92;
            }
            if (fuel > 25)
            {
                discount = 0.9;
            }
            if (fuelType == "Gasoline")
            {
                totalFuel = (fuel * gasolinePrice) * discount;
            }
            else if (fuelType == "Diesel")
            {
                totalFuel = (fuel * dieselPrice) * discount;
            }
            else if (fuelType == "Gas")
            {
                totalFuel = (fuel * gasPrice) * discount;
            }

            Console.WriteLine($"{totalFuel:f2} lv.");
        }
    }
}
