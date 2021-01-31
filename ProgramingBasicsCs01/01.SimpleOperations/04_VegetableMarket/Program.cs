using System;

namespace _04_VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePriceKg = double.Parse(Console.ReadLine());
            double fruitPriceKg = double.Parse(Console.ReadLine());
            double vegetableTotalKg = double.Parse(Console.ReadLine());
            double fruitTotalKg = double.Parse(Console.ReadLine());
            double euro = 1.94;
            double totalInEuro = ((vegetablePriceKg*vegetableTotalKg) + (fruitPriceKg*fruitTotalKg))/euro;
            Console.WriteLine($"{totalInEuro:f2}");
        }
    }
}
