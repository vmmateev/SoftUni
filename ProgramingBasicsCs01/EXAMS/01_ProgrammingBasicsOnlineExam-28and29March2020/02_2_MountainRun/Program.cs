using System;

namespace _02_2_MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeToBeatSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeClimbingOneMetSeconds = double.Parse(Console.ReadLine());

            double timeToClimb = distanceMeters * timeClimbingOneMetSeconds;
            double timeSlowed = (Math.Floor(distanceMeters / 50)) * 30;
            double totalTimeNeeded = timeToClimb + timeSlowed;
            double timeDiff = totalTimeNeeded - timeToBeatSeconds;

            if (timeToBeatSeconds > totalTimeNeeded)
            {
                Console.WriteLine($"Yes! The new record is {totalTimeNeeded:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {timeDiff:f2} seconds slower.");
            }

        }
    }
}
