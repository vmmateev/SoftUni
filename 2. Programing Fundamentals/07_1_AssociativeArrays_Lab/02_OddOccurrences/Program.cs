using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray(); // Четем думи от конзолата
            Dictionary<string, int> loweredOddWords = new Dictionary<string, int>(); //създаваме речник е ключ стрингове (думите от масива) и стойност (броя на тяхното съдържание в масива)
            foreach (var word in words)
            {
                string loweredWord = word.ToLower();    // правим ги с малки букви
                if (loweredOddWords.ContainsKey(loweredWord))
                {
                    loweredOddWords[loweredWord]++;
                }
                else
                {
                    loweredOddWords.Add(loweredWord, 1);
                }
            }
            foreach (var kvp in loweredOddWords)
            {
                if (kvp.Value%2!=0)
                {
                    Console.Write(kvp.Key+" ");
                }
            }
        }
    }
}
