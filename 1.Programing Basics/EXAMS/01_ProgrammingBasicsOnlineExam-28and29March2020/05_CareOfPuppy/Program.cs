using System;

namespace _05_CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDogFood = int.Parse(Console.ReadLine());
            string input = "";
            double totalFoodEaten = 0;
            while ((input = Console.ReadLine()) != "Adopted")
            {
                double dailyFood = double.Parse(input);
                totalFoodEaten += dailyFood;
            }
            totalDogFood *= 1000;
            if (totalDogFood >= totalFoodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {(totalDogFood) - totalFoodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - totalDogFood} grams more.");
            }
        }
    }
}
