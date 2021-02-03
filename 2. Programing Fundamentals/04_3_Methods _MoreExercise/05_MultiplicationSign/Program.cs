using System;

namespace _05_MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCount = 0;
            int pCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    nCount++;
                }
                else if (num > 0)
                {
                    pCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            if (nCount % 2 != 0 && zeroCount == 0)
            {
                Console.WriteLine("negative");
            }
            else if (zeroCount > 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
