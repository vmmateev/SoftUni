using System;

namespace _01_UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            for (int i = 2; i <= number1; i += 2)
            {
                for (int j = 2; j <= number2; j++)
                {
                    for (int k = 2; k <= number3; k += 2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {   
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
