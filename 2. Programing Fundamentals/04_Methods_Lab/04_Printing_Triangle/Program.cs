using System;

namespace _04_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                HalfTrianglePrint(row);
                Console.WriteLine();
            }

            for (int inverseRow = num - 1; inverseRow >= 0; inverseRow--)
            {
                HalfTrianglePrint(inverseRow);
                Console.WriteLine();
            }
        }

        static void HalfTrianglePrint(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
        }
    }
}
