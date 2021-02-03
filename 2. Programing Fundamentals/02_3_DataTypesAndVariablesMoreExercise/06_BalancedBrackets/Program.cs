using Microsoft.VisualBasic;
using System;

namespace _06_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int open = 0;
            int close = 0;
            bool isBalanced = true;
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    open++;
                }
                else if (input == ")")
                {
                    close++;
                }
                if (close > open)
                {
                    isBalanced = false;
                    break;
                }
            }
            if (open == close && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
