using System;

namespace _06_CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double rectangleArea = GetRectangleArea(first, second);
            Console.WriteLine(rectangleArea);
        }

        static double GetRectangleArea(double first, double second)
        {
            double result = first * second;
            return result;
        }
    }
}
