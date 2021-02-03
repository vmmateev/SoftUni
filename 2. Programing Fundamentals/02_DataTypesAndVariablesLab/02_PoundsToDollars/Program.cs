using System;

namespace _02_PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollars = pound * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
