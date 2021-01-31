using System;

namespace _08_CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;
            double circlePerimeter = 2 * Math.PI * radius;

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{circlePerimeter:f2}");
        }
    }
}

