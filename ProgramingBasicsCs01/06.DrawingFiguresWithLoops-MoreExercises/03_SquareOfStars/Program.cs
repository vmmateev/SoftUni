﻿using System;

namespace _03_SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
