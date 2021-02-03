using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split().ToArray();
                if (input[0] == "Add")
                {
                    trainWagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int newPassengers = int.Parse(input[0]);

                    for (int i = 0; i < trainWagons.Count; i++)
                    {
                        int freeSpaceInWagon = maxCapacity - trainWagons[i];
                        if (newPassengers <= freeSpaceInWagon)
                        {
                            trainWagons[i] += newPassengers;
                            newPassengers = 0;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", trainWagons));
        }
    }
}
