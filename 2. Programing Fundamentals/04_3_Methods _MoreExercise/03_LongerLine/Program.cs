using System;

namespace _03_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputX1 = double.Parse(Console.ReadLine());
            double inputY1 = double.Parse(Console.ReadLine());

            double inputX2 = double.Parse(Console.ReadLine());
            double inputY2 = double.Parse(Console.ReadLine());
            
            
            double inputX3 = double.Parse(Console.ReadLine());
            double inputY3 = double.Parse(Console.ReadLine());

            double inputX4 = double.Parse(Console.ReadLine());
            double inputY4 = double.Parse(Console.ReadLine());
            LongerLine(inputX1, inputY1, inputX2, inputY2,inputX3,inputY3,inputX4,inputY4);
        }

        static void NearZero(double x1, double y1, double x2, double y2)
        {
            double sumFirst = Math.Sqrt(Math.Pow(Math.Abs(x1), 2) + Math.Pow(Math.Abs(y1), 2));
            double sumSecond = Math.Sqrt(Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2));
           
            if (sumFirst > sumSecond)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
        static void LongerLine(double a,double b, double c , double d , double e, double f, double g, double h)
        {
            double sumFirst = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double sumSecond = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - h), 2));
            if (sumFirst>=sumSecond)
            {
                NearZero(a, b, c, d);
            }
            else
            {
                NearZero(e, f, g, h);
            }
        }
    }
}
