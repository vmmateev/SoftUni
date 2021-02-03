using System;
using System.Linq;

namespace _02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            for (int i = 0; i < second.Length; i++)
            {
                for (int k = 0; k < first.Length; k++)
                {
                    if (second[i] == first[k])
                    {
                        Console.Write(first[k] + " ");
                    }
                }
            }
        }
    }
}
