﻿using System;

namespace _03_CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double farenheit = celsius * 1.800 + 32;
            Console.WriteLine($"{farenheit:F2}");
        }
    }
}
