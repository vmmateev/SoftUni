using System;
using System.Runtime.InteropServices;

namespace _02_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputX1 = double.Parse(Console.ReadLine());
            double inputY1 = double.Parse(Console.ReadLine());

            double inputX2 = double.Parse(Console.ReadLine());
            double inputY2 = double.Parse(Console.ReadLine());
            CenterPointChecker(inputX1,inputY1,inputX2,inputY2);
        }

        static void CenterPointChecker (double x1, double y1, double x2, double y2)
        {
            double sumFirst = Math.Abs(x1) + Math.Abs(y1);
            double sumSecond = Math.Abs(x2) + Math.Abs(y2);
            if (sumFirst<sumSecond)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            
        }
    }
}
