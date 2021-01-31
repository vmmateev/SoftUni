using System;

namespace _03_EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitType = Console.ReadLine();
            string size = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());

            double totalSum = 0;
            if (fruitType == "Watermelon")
            {
                if (size == "small")
                {
                    totalSum = setCount * 2 * 56;
                }
                else if (size == "big")
                {
                    totalSum = setCount * 5 * 28.7;
                }
            }
            else if (fruitType == "Mango")
            {
                if (size == "small")
                {
                    totalSum = setCount * 2 * 36.66;
                }
                else if (size == "big")
                {
                    totalSum = setCount * 5 * 19.6;
                }
            }
            else if (fruitType == "Pineapple")
            {
                if (size == "small")
                {
                    totalSum = setCount * 2 * 42.1;
                }
                else if (size == "big")
                {
                    totalSum = setCount * 5 * 24.8;
                }
            }
            else if (fruitType == "Raspberry")
            {
                if (size == "small")
                {
                    totalSum = setCount * 2 * 20;
                }
                else if (size == "big")
                {
                    totalSum = setCount * 5 * 15.2;
                }
            }

            double discount = 1;
            if (totalSum>=400 && totalSum<=1000)
            {
                discount = 0.85;
            }
            else if (totalSum>1000)
            {
                discount = 0.5;
            }

            double totalSumWithDiscount = totalSum * discount;

            Console.WriteLine($"{totalSumWithDiscount:f2} lv.");
        }
    }
}
