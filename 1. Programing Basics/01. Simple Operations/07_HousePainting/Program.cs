using System;

namespace _07_HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double xHeightHouse = double.Parse(Console.ReadLine());
            double yLenghtSideWall = double.Parse(Console.ReadLine());
            double hHeightTriangleRoof = double.Parse(Console.ReadLine());

            double doorArea = 1.2 * 2;
            double windowArea = 1.5 * 1.5;

            double frontWall = xHeightHouse * xHeightHouse;
            double sideWall = xHeightHouse * yLenghtSideWall;

            double roofArea = 2 * (xHeightHouse * yLenghtSideWall) + 2 * ((xHeightHouse * hHeightTriangleRoof) / 2);

            double houseArea = ((2 * frontWall) + (2 * sideWall)) - doorArea - windowArea - windowArea;
            double totalGreenPaint = houseArea / 3.4;

            double totalRedPaint = roofArea / 4.3;

            Console.WriteLine($"{totalGreenPaint:f2}");
            Console.WriteLine($"{totalRedPaint:f2}");
        }
    }
}
