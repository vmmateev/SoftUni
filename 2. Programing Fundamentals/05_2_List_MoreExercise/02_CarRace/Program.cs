using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> carTime = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftSum = 0;
            double rightSum = 0;
            int leftBorder = carTime.Count / 2;
            int rightBorder = carTime.Count / 2;
            //Left car
            for (int i = 0; i < leftBorder; i++)
            {
                leftSum += carTime[i];
                if (carTime[i] == 0)
                {
                    leftSum *= 0.8;
                }
            }
            //Right Car
            for (int j  = carTime.Count - 1; j > rightBorder; j--)
            {
                rightSum += carTime[j];
                if (carTime[j] == 0)
                {
                    rightSum *= 0.8;
                }
            }

            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
