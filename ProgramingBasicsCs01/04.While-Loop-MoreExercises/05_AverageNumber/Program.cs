using System;

namespace _05_AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double sum = 0;
            double total=0;
            for (int i = 0; i < number; i++)
            {
                sum = double.Parse(Console.ReadLine());
                total += sum;
            }
            Console.WriteLine($"{(total/number):f2}");
        }
    }
}
