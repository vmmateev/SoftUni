using System;

namespace _04_FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double totalBiscuits = 0;
            double totalFoodEaten = 0;
            double totalDogFoodEaten = 0;
            double totalCatFoodEaten = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                totalDogFoodEaten += dogFood;
                double catFood = double.Parse(Console.ReadLine());
                totalCatFoodEaten += catFood;
                totalFoodEaten += dogFood + catFood;
                if (i % 3 == 0)
                {
                    double dayBiscuit = (dogFood + catFood) * 0.1;
                    totalBiscuits += dayBiscuit;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");

            Console.WriteLine($"{((totalFoodEaten / totalFood) * 100):f2}% of the food has been eaten.");
            Console.WriteLine($"{((totalDogFoodEaten / totalFoodEaten) * 100):f2}% eaten from the dog.");
            Console.WriteLine($"{((totalCatFoodEaten / totalFoodEaten) * 100):f2}% eaten from the cat.");
        }
    }
}
