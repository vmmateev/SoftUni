using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] partyList = Console.ReadLine().Split().ToArray();

                if (partyList[2] == "going!")
                {
                    if (!names.Contains(partyList[0]))
                    {
                        names.Add(partyList[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{partyList[0]} is already in the list!");
                    }
                }
                else if (partyList[2]=="not")
                {
                    if (names.Contains(partyList[0]))
                    {
                        names.Remove(partyList[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{partyList[0]} is not in the list!");
                    }
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
