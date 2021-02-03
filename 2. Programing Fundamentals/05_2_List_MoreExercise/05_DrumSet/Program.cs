using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSavings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            List<int> priceDrum = drumSet.ToList();
            
            while ((command=Console.ReadLine())!="Hit it again, Gabsy!")
            {
                int currentPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= currentPower;
                    if (drumSet[i]<=0)
                    {
                        if (totalSavings>=priceDrum[i]*3)
                        {
                        drumSet[i] = priceDrum[i];
                        totalSavings -= priceDrum[i]*3;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            priceDrum.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {totalSavings:f2}lv.");
        }
    }
}
