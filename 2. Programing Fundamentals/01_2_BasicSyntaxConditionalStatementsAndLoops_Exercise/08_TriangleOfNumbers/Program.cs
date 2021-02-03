using System;

namespace _08_TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter != number)
            {
                for (int i = 0; i <= counter; i++)
                {
                    Console.Write(counter + 1 + " ");
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
