using System;
using System.Linq;

namespace _10_LadyBug_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] indexLadybugs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] command = input.Split().ToArray();
                int ladyBugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLenght = int.Parse(command[2]);
            }
        }
    }
}
