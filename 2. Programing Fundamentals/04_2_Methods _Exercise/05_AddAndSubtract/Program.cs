using System;

namespace _05_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(num1, num2, num3));
        }
        static int Sum(int number1, int number2, int number3)
        {
            int resultSum = number1 + number2;
            return Subtract(resultSum, number3);
        }
        static int Subtract(int summedNum, int num3)
        {
            int subtractResult = summedNum - num3;
            return subtractResult;
        }
    }
}
