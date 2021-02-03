using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split().ToArray();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) > numbers.Count - 1 || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) > numbers.Count - 1 || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[1] == "left")
                {
                    int rotations = int.Parse(command[2]);
                    for (int i = 0; i < rotations; i++)
                    {
                        int firstTemp = numbers[0];
                        numbers.Insert(numbers.Count, firstTemp);
                        numbers.RemoveAt(0);
                    }
                }
                else if (command[1] == "right")
                {
                    int rotations = int.Parse(command[2]);
                    for (int i = 0; i < rotations; i++)
                    {
                        int lastTemp = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastTemp);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
