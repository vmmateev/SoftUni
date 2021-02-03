using System;

namespace _07_NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = int.Parse(Console.ReadLine());

            TriangleDraw(param);
        }

        static void TriangleDraw(int param)
        {
            for (int row = 0; row < param; row++)
            {
                for (int col = 0; col < param; col++)
                {
                    Console.Write(param + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
