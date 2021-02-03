using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();

            if (firstList.Count<secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
