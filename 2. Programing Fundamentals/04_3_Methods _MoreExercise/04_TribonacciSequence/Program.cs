using System;
using System.Xml.XPath;

namespace _04_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = TribonacciGenerator(number);
            Console.WriteLine(result);
        }

        static string TribonacciGenerator(int num)
        {
            string result = "";
            if (num == 1)
            {
                return result = "1";
            }
            else if (num == 2)
            {
                return result = "1 1";
            }
            else if (num == 3)
            {
                return result = "1 1 2";
            }
            else
            {
                int[] resultPrint = new int[num];
                resultPrint[0] = 1;
                resultPrint[1] = 1;
                resultPrint[2] = 2;
                for (int i = 3; i < resultPrint.Length; i++)
                {
                    resultPrint[i] = resultPrint[i - 1] + resultPrint[i - 2] + resultPrint[i - 3];
                }
                result = string.Join(" ", resultPrint);
                return result;
            }

        }
    }
}
