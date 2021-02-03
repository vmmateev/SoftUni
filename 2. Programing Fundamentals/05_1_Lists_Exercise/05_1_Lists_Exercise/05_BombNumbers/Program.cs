using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bombAndPower[0];
            int power = bombAndPower[1];

            while (sequence.Contains(bombNumber))
            {   
                    for (int j = 0; j < power; j++)
                    {
                        int BombIndex = sequence.IndexOf(bombNumber);
                        if (BombIndex - 1 >= 0)
                        {
                            sequence.RemoveAt(BombIndex - 1);
                        }
                    BombIndex = sequence.IndexOf(bombNumber); //refresh bomb index after first delete of elements from the left
                    if (BombIndex + 1 <= sequence.Count - 1)
                        {
                            sequence.RemoveAt(BombIndex + 1);
                        }
                    }
                    sequence.Remove(bombNumber);
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}


