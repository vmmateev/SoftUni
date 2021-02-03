using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<int> output = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> cache = input[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int k = 0; k < cache.Count; k++)
                {
                    output.Add(cache[k]);
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
