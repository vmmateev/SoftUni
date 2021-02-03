using System;

namespace _04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int loops = int.Parse(Console.ReadLine());
            while (loops != 0)
            {
                string temp = numbers[0];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                numbers[numbers.Length-1] = temp;
                loops--;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
