using System;
using System.IO;

namespace _05_2_SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkSpace = double.Parse(Console.ReadLine());
            string input = "";
            int suitCaseCounter = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                suitCaseCounter++;
                double suitCaseVolume = double.Parse(input);
                if (suitCaseCounter%3==0)
                {
                    suitCaseVolume = suitCaseVolume * 1.1;
                }
                trunkSpace -= suitCaseVolume;
                if (trunkSpace<0)
                {
                    suitCaseCounter--;
                    Console.WriteLine("No more space!");
                    break;
                }

            }
            if (input=="End")
            {
            Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitCaseCounter} suitcases loaded.");
        }
    }
}
