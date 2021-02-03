using System;

namespace _03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "add":
                    Add(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiply(firstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(firstNum, secondNum);
                    break;
                case "divide":
                    Divide(firstNum, secondNum);
                    break;
            }
        }
        static void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
        static void Subtract(int first, int second)
        {
            Console.WriteLine(first - second);
        }
        static void Divide(int first, int second)
        {
            Console.WriteLine(first / second);
        }

    }
}
