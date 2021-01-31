using System;

namespace _07_FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnoliaCount = double.Parse(Console.ReadLine());
            double ziumbulCount = double.Parse(Console.ReadLine());
            double roseCount = double.Parse(Console.ReadLine());
            double cactusCount = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalCart = (magnoliaCount * 3.25) + (ziumbulCount * 4) + (roseCount * 3.5) + (cactusCount * 8);
            totalCart -= totalCart * 0.05;

            if (totalCart >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalCart - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalCart)} leva.");
            }

        }
    }
}
