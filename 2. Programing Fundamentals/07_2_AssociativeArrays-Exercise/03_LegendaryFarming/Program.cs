using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 }
                };
            //keyMaterials.Add("shards", 0);
            //keyMaterials.Add("motes", 0);
            //keyMaterials.Add("fragments", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            bool itemNotObtained = true;
            string legendaryMaterialsObtained = string.Empty;

            while (itemNotObtained)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    input[i] = input[i].ToLower();
                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        keyMaterials[input[i]] += int.Parse(input[i - 1]);

                        if (keyMaterials[input[i]] >= 250)
                        {
                            legendaryMaterialsObtained = input[i];
                            keyMaterials[input[i]] -= 250;
                            itemNotObtained = false;

                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(input[i]))
                        {
                            junkMaterials[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            junkMaterials[input[i]] += int.Parse(input[i - 1]);
                        }
                    }
                    if (!itemNotObtained)
                    {
                        break;
                    }
                }
            }
            if (legendaryMaterialsObtained == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legendaryMaterialsObtained == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (legendaryMaterialsObtained == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }

            PrintMaterials(keyMaterials, junkMaterials);
        }

        private static void PrintMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
