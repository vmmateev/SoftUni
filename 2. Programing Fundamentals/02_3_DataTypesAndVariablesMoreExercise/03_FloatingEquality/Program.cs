using System;

namespace _03_FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double constantEPS = 0.000001;
            double difference = Math.Abs(first-second);
            if (difference>constantEPS)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
