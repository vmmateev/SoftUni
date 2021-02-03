using System;

namespace _02_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                int num = number % 10;
                sum += num;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
