using System;

namespace _06_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysCount = double.Parse(Console.ReadLine());
            double leftFoodKilos = double.Parse(Console.ReadLine());
            double dogFoodKilos = double.Parse(Console.ReadLine());
            double catFoodKilos = double.Parse(Console.ReadLine());
            double turtleFoodGrams = double.Parse(Console.ReadLine());

            double turtleFoodinKilos = turtleFoodGrams / 1000;

            double totalDogFood = daysCount * dogFoodKilos;
            double totalCatFood = daysCount * catFoodKilos;
            double totalTurtleFood = daysCount * turtleFoodinKilos;
            double totalFOOD = totalCatFood + totalDogFood + totalTurtleFood;

            if (leftFoodKilos >= totalFOOD)
            {
                Console.WriteLine($"{Math.Floor(leftFoodKilos - totalFOOD)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFOOD - leftFoodKilos)} more kilos of food are needed.");
            }
        }
    }
}
