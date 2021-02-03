using System;
using System.Collections.Generic;

namespace _01_AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> Events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> Authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> Cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int input = int.Parse(Console.ReadLine());
            Random Randomizer = new Random();
            for (int i = 0; i < input; i++)
            {
                Console.Write(Phrases[Randomizer.Next(0, Phrases.Count)]+" ");
                Console.Write(Events[Randomizer.Next(0, Events.Count)]+" ");
                Console.Write(Authors[Randomizer.Next(0, Authors.Count)]+" - ");
                Console.Write(Cities[Randomizer.Next(0, Cities.Count)]);
                Console.WriteLine();
            }
        }
    }
}
