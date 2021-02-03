using System;

namespace _04_PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
                totalSum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
