using System;

namespace _08_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double poweredNumber = GetNumbersOnPower(number, power);
            Console.WriteLine(poweredNumber);

        }

        static double GetNumbersOnPower(double first, int second)
        {
            double result= 1;
            for (int i = 0; i < second; i++)
            {
                result *= first;
            }
            return result;
        }
    }
}
