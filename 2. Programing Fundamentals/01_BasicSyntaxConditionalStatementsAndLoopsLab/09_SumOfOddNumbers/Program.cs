using System;

namespace _09_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number * 2; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
