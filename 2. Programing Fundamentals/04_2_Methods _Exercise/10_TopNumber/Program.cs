using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace _10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int oddCount = 0;
                int test = i;
                while (test != 0)
                {
                    int lastDigit = test % 10;
                    if (lastDigit % 2 != 0)
                    {
                        oddCount++;
                    }
                    sum += lastDigit;
                    test /= 10;
                }
                if (sum % 8 == 0 && oddCount > 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
