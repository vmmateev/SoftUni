using System;
using System.Linq;

namespace _04_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //numbers.Sort();
            //var numbersToPrint = numbers.TakeLast(3).ToList();
            //for (int i = numbersToPrint.Count - 1; i >= 0; i--)
            //{
            //    Console.Write(numbersToPrint[i] + " ");
            //}

            var numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
