using System;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numArr = new int[number];
            int sum = 0; // numArr.Sum();
            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numArr[i] = input;
                sum += input;
            }
            foreach (var numbers in numArr)
            {
                Console.Write(numbers+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
