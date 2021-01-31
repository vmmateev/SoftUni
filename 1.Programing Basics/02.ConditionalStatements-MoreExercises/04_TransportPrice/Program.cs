using System;

namespace _04_TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmCount = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();

            double taxiStartCharge = 0.7;
            double taxyPriceTotal = 0;
            double busPriceTotal = 0;
            double trainTotalPrice = 0;
            if (dayNight == "day")
            {
                taxyPriceTotal = taxiStartCharge + (kmCount * 0.79);
                busPriceTotal = kmCount * 0.09;
                trainTotalPrice = kmCount * 0.06;
            }
            else if (dayNight == "night")
            {
                taxyPriceTotal = taxiStartCharge + (kmCount * 0.9);
                busPriceTotal = kmCount * 0.09;
                trainTotalPrice = kmCount * 0.06;
            }
            double taxyORbus = Math.Min(taxyPriceTotal, busPriceTotal);

            if (kmCount < 20)
            {
                Console.WriteLine($"{taxyPriceTotal:f2}");
            }

            else if (kmCount >= 100)
            {
                if (trainTotalPrice < taxyORbus)
                {
                    Console.WriteLine($"{trainTotalPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"{taxyORbus:f2}");
                }

            }
            else
            {
                Console.WriteLine($"{taxyORbus:f2}");
            }

        }
    }
}
