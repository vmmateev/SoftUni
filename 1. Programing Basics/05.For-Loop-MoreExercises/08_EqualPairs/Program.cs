using System;

namespace _08_EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pair1 = 0;
            double pair2 = 0;
            double diff = 0;
            double maxDiff = 0;

            for (int i = 0; i < number; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                pair1 = number1 + number2;
                if (i > 0)
                {
                    if (pair1 != pair2)
                    {
                        diff = Math.Abs(pair1 - pair2);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                }
                pair2 = pair1;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={pair2}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
