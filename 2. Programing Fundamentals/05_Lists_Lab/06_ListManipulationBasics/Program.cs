using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> commands = command.Split().ToList();
                string firstCommand = commands[0];
                int number = int.Parse(commands[1]);
                if (firstCommand == "Add")
                {
                    numbers.Add(number);
                }
                else if (firstCommand == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (firstCommand == "RemoveAt")
                {
                    numbers.RemoveAt(number);
                }
                else if (firstCommand == "Insert")
                {
                    int number2 = int.Parse(commands[2].ToString());
                    numbers.Insert(number2, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
