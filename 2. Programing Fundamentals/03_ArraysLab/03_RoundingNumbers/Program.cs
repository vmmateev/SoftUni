using System;
using System.Linq;

namespace _03_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {   
                Console.WriteLine($"{(decimal)numbers[i]} => {(decimal)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
