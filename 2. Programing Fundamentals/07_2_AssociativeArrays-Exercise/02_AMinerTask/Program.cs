using System;
using System.Collections.Generic;
using System.Threading;

namespace _02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> collectedResource = new Dictionary<string, int>();
            int counter = 0;
            string resourceName = string.Empty;
            while ((input = Console.ReadLine()) != "stop")
            {
                if (counter % 2 == 0)
                {
                    if (!collectedResource.ContainsKey(input))
                    {
                        collectedResource[input] = 0;
                    }
                }
                else
                {
                    int resource = int.Parse(input);
                    collectedResource[resourceName] += resource;

                }
                counter++;
                resourceName = input;

            }


            foreach (var kvp in collectedResource)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
