using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersToManipulate = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split().ToArray();
                int number = int.Parse(input[1]);
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < numbersToManipulate.Count; i++)
                    {
                        if (number == numbersToManipulate[i])
                        {
                            numbersToManipulate.Remove(number);
                        }
                    }
                }
                else if (input[0] == "Insert")
                {
                    int index = int.Parse(input[2]);
                    numbersToManipulate.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbersToManipulate));
        }
    }
}
