using System;

namespace _11_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            double result = Calculate(first, operation, second);

            Console.WriteLine($"{result}");
        }

        static double Calculate(int num1, string oper, int num2)
        {
            double result = 0;
            switch (oper)
            {
                case "/":
                    result = (double)num1 / num2;
                    break;
                    case "*":
                    result = num1 * num2;
                    break;
                    case "+":
                    result = num1 + num2;
                    break;
                    case "-":
                    result = num1 - num2;
                    break;
            }
            return result;
        }
    }
}
