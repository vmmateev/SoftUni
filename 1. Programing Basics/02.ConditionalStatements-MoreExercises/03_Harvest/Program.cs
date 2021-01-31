using System;

namespace _03_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double xSquareMland = double.Parse(Console.ReadLine());
            double yGrapePerM = double.Parse(Console.ReadLine());
            double wineNeededSell = double.Parse(Console.ReadLine());
            double workerCount = double.Parse(Console.ReadLine());


            double harvestForWine = xSquareMland * 0.4;

            double producedWineLiter = (harvestForWine * yGrapePerM) / 2.5;

            if (wineNeededSell > producedWineLiter)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeededSell - producedWineLiter)} liters wine needed.");
            }
            else
            {
                double wineForWorkers = (producedWineLiter - wineNeededSell) / workerCount;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWineLiter)} liters.");
                Console.WriteLine($"{Math.Ceiling(producedWineLiter - wineNeededSell)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
            }
        }
    }

}
