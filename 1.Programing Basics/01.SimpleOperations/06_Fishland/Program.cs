using System;

namespace _06_Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double scomberPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double beltedBonitoQuantityInKilo = double.Parse(Console.ReadLine());
            double scadQuantityInKilo = double.Parse(Console.ReadLine());
            double clamQuantityInKilo = double.Parse(Console.ReadLine());

            double beltedBonitoPrice = (scomberPrice * 0.6 )+ scomberPrice;
            double scadPrice = (spratPrice * 0.8) + spratPrice;
            double clamPrice = 7.50;

            double totalValue = (beltedBonitoPrice * beltedBonitoQuantityInKilo) + (scadPrice * scadQuantityInKilo) + (clamPrice * clamQuantityInKilo);
            Console.WriteLine($"{totalValue:f2}");
        }
    }
}
