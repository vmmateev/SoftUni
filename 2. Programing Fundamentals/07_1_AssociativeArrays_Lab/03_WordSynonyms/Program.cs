using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms[word].Add(synonym);
                }
                else
                {
                    wordsSynonyms.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var item in wordsSynonyms)
            {
                Console.Write($"{item.Key} - ");
                var tempList = item.Value.ToList();
                Console.Write(string.Join(", ", tempList));
                Console.WriteLine();
            }

            foreach (var key in wordsSynonyms.Keys) // Втори вариянт
            {
                Console.Write($"{key} - ");
                var tempList = wordsSynonyms[key].ToList();
                Console.Write(string.Join(", ", tempList));
                Console.WriteLine();
            }
        }
    }
}
