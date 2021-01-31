using System;

namespace _02_CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalkingDay = int.Parse(Console.ReadLine());
            int walkingCountDay = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            double caloriesNeededToBurn = (caloriesTaken * 50) / 100;

            double caloriesBurned = walkingCountDay * minutesWalkingDay * 5;

            if (caloriesNeededToBurn <= caloriesBurned)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
