using System;

namespace _01_SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = GetMinOfThree(num1,num2,num3);
            Console.WriteLine(result);
        }
        static int GetMinOfThree(int first, int second, int third)
        {
            int result = Math.Min(first, Math.Min(second, third));
            return result;

        }
    }
}
