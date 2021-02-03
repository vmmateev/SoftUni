using System;

namespace _01_Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = first + second;
            double division = sum / third;
            double multi = division * fourth;
            Console.WriteLine(multi);
        }
    }
}
