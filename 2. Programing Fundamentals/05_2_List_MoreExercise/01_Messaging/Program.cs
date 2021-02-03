using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string inputString = Console.ReadLine();
            string result = string.Empty;
            
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                int currentNumber = inputNumbers[i];
                int sum = 0;
                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    sum += digit;
                    currentNumber /= 10;
                }
                if (sum > inputString.Length)
                {
                    sum = sum - inputString.Length;
                }
                result += inputString[sum];
                string tempInput = inputString.Remove(sum, 1);
                inputString = tempInput;
            }
            Console.WriteLine(result);
        }
    }
}
