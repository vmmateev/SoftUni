using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>(Console.ReadLine().Split());
            var rnd = new Random();
            for (int i = 0; i < input.Count; i++)
            {
                int randomIndex = rnd.Next(0, input.Count);
                string randElement = input[randomIndex];
                string element = input[i];

                input[randomIndex] = element;
                input[i] = randElement;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
