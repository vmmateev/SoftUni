using System;

namespace _01_ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoin = decimal.Parse(Console.ReadLine());
            decimal chinaCoin = decimal.Parse(Console.ReadLine());
            decimal commision = decimal.Parse(Console.ReadLine());

            decimal bitCoinInLV = bitcoin * 1168;
            decimal chinaCoinInLV = (chinaCoin * (decimal)0.15)*(decimal)1.76;
            decimal totalEUR = (bitCoinInLV + chinaCoinInLV) / (decimal)1.95;
            totalEUR -= (totalEUR*commision)/100;

            Console.WriteLine($"{totalEUR:f2}");

        }
    }
}
