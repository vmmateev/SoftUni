using System;

namespace _01_2_SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double penCount = double.Parse(Console.ReadLine());
            double markerCount = double.Parse(Console.ReadLine());
            double cleanerDesk = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalMoney = (penCount * 5.8) + (markerCount * 7.2) + (cleanerDesk * 1.2);
            totalMoney -= (totalMoney * discount) / 100;

            Console.WriteLine($"{totalMoney:f3}");
        }
    }
}
