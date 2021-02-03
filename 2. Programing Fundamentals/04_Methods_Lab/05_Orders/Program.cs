using System;

namespace _05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productCount = int.Parse(Console.ReadLine());
            PricePrint(productName, productCount);
        }

        static void PricePrint(string name, int count)
        {
            switch (name)
            {
                case "coffee":
                    Console.WriteLine($"{(count * 1.5):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{(count * 1):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(count * 1.4):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(count * 2):f2}");
                    break;
            }
        }
    }
}
