using System;

namespace _01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Lstring input = Console.ReadLine();
            string inputSecond = Console.ReadLine();

            if (input == "int")
            {
                int temp = int.Parse(inputSecond);
                FormatOutput(temp);

            }
            else if (input == "real")
            {
                double temp = double.Parse(inputSecond);
                FormatOutput(temp);
            }
            else if (input == "string")
            {
                FormatOutput(inputSecond);
            }
        }
        static void FormatOutput(int SecondArg)
        {
            Console.WriteLine(SecondArg * 2);
        }
        static void FormatOutput(double SecondArg)
        {
            Console.WriteLine($"{(SecondArg * 1.5):f2}");
        }
        static void FormatOutput(string SecondArg)
        {
            Console.WriteLine($"${SecondArg}$");
        }
    }
    }
}
