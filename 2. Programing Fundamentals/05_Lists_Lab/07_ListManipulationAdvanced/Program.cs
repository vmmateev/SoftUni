using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            bool isEdited = false;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> commands = command.Split().ToList();
                List<int> result = new List<int>();
                

                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                    isEdited = true;
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                    isEdited = true;
                }
                else if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                    isEdited = true;
                }
                else if (commands[0] == "Insert")
                {
                    int number2 = int.Parse(commands[2].ToString());
                    numbers.Insert(number2, int.Parse(commands[1]));
                    isEdited = true;
                }
                else if (commands[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            result.Add(numbers[i]);
                        }
                    }
                        Console.WriteLine(string.Join(" ", result));
                }
                else if (commands[0]=="PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            result.Add(numbers[i]);
                        }
                    }
                        Console.WriteLine(string.Join(" ", result));
                }
                else if (commands[0]=="GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (commands[0]=="Filter")
                {
                    int number = int.Parse(commands[2]);
                    if (commands[1]=="<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]<number)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",result));
                    }
                    else if (commands[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (commands[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (commands[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                    }

                }
            }
            if (isEdited)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
