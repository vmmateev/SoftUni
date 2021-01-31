using System;

namespace _03_2FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOwned = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sportType = Console.ReadLine();

            double discount = 0.8;
            double sumNeeded = 0;
            if (gender == "m")
            {
                if (sportType == "Gym")
                {
                    sumNeeded = 42;
                }
                else if (sportType == "Boxing")
                {
                    sumNeeded = 41;
                }
                else if (sportType == "Yoga")
                {
                    sumNeeded = 45;
                }
                else if (sportType == "Zumba")
                {
                    sumNeeded = 34;
                }
                else if (sportType == "Dances")
                {
                    sumNeeded = 51;
                }
                else if (sportType == "Pilates")
                {
                    sumNeeded = 39;
                }
            }
            else if (gender == "f")
            {
                if (sportType == "Gym")
                {
                    sumNeeded = 35;
                }
                else if (sportType == "Boxing")
                {
                    sumNeeded = 37;
                }
                else if (sportType == "Yoga")
                {
                    sumNeeded = 42;
                }
                else if (sportType == "Zumba")
                {
                    sumNeeded = 31;
                }
                else if (sportType == "Dances")
                {
                    sumNeeded = 53;
                }
                else if (sportType == "Pilates")
                {
                    sumNeeded = 37;
                }
            }

            if (age<=19)
            {
                sumNeeded *= discount;
            }
            if (sumNeeded<=sumOwned)
            {

            Console.WriteLine($"You purchased a 1 month pass for {sportType}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(sumNeeded-sumOwned):f2} more.");
            }
        }
    }
}
