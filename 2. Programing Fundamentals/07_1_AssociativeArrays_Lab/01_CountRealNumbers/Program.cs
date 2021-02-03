using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number)) //Търси дали има такъв ключ (число от масива на вход) ако има увеличава с едно колко пъти е срещнато числото ако не го добавя в 1 срещане
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var kvp in counts)
            {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
