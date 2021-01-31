using System;

namespace _01_TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideB1 = double.Parse(Console.ReadLine());
            double sideB2 = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());

            double area = (sideB1 + sideB2) * (double)sideH / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
