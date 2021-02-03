using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_TakeORSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numberList = new List<int>();
            List<char> charList = new List<char>();
            //skipTest_String
            List<int> TakeEvenList = new List<int>();
            //Take list: [0, 4, 7]
            List<int> SkipOddList = new List<int>();
            //Skip list: [4, 1, 0]

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {   
                    numberList.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    charList.Add(input[i]);
                }
            }

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i%2!=0)
                {
                    SkipOddList.Add(numberList[i]);
                }
                else 
                {
                    TakeEvenList.Add(numberList[i]);
                }
            }
            //Console.WriteLine($"Number List:     {string.Join(" ",numberList)}");
            //Console.WriteLine($"Char list:       {string.Join("",charList)}");
            //Console.WriteLine($"Take List EVENS: {string.Join(" |", TakeEvenList)}");
            //Console.WriteLine($"Skip List ODDS:  {string.Join(" |", SkipOddList)}");
            int total = 0;
            for (int i = 0; i < TakeEvenList.Count; i++)
            {
                int skipper = SkipOddList[i];
                int taker = TakeEvenList[i];
                result += new string(charList.Skip(total).Take(taker).ToArray()); // Скипва тотал чарове взима дадените и добавя към масива събира взетите и прескочените и ги сумира
                total += skipper + taker;
            }
            Console.WriteLine(result);
        }
    }
}
