using System;

namespace _02_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());

            double triangleArea = sideA * sideH / 2;
            Console.WriteLine($"{triangleArea:f2}");
        }
    }
}
