using System;

namespace _10_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int edinLev = int.Parse(Console.ReadLine());
            int dvaLeva = int.Parse(Console.ReadLine());
            int petLeva = int.Parse(Console.ReadLine());

            int totalSum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= edinLev; i++)
            {
                for (int j = 0; j <= dvaLeva; j++)
                {
                    for (int k = 0; k <= petLeva; k++)
                    {
                        if ((i*1)+(j*2)+(k*5)==totalSum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {totalSum} lv.");
                        }
                    }
                }
            }
        }
    }
}
