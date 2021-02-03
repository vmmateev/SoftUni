using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_MultiplyBugNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int sum = 0;

            foreach (char ch in bigNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = (digit * smallNumber) + sum;
                int resDigit = result % 10;
                sb.Insert(0, resDigit);
                sum = result / 10;
            }

            if (sum > 0)
            {
                sb.Insert(0, sum);
            }

            string output = sb.ToString().TrimStart('0');
            if (output.Length == 0)
            {
                output = "0";
            }
            Console.WriteLine(output);
        }
    }
}
