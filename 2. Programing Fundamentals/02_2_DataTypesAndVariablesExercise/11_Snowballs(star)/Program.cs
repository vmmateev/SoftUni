using System;
using System.Numerics;
namespace _11_Snowballs_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            string print = "";
            for (int i = 0; i < ballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (currentValue >= snowballValue)
                {
                    snowballValue = currentValue;
                    print = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(print);
        }
    }
}
