using System;

namespace _04_TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string dollar = "$";
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(dollar + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
