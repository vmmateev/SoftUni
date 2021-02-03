using System;

namespace _06_StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNumber = number;
            int sum = 1;
            int totalSum = 0;
            while (copyNumber > 0)
            {
                int loop = copyNumber % 10;
                for (int i = 1; i <= loop; i++)
                {
                    sum *= i;
                }
                totalSum += sum;
                sum = 1;
                copyNumber /= 10;
            }
            if (number == totalSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
