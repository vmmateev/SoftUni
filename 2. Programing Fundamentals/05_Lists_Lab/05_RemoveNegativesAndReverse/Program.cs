using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            // Vtori variant!!!

            //List<int> result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}
            //result.Reverse();
            //if (result.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ", result));
            //}
        }
    }
}
