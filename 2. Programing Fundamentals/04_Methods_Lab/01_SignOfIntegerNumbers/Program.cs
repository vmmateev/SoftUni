﻿using System;

namespace _01_SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignCheckNumber(number);

            static void SignCheckNumber(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine($"The number {num} is negative.");
                }
                else if (num > 0)
                {
                    Console.WriteLine($"The number {num} is positive.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is zero.");
                }
            }
        }
    }
}