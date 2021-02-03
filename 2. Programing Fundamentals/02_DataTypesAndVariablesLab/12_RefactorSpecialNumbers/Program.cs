using System;

namespace _12_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;
            //}

            int totalNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            bool isSpecial = false;
            for (int i = 1; i <= totalNumbers; i++)
            {
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
                sum = 0;
            }
        }
    }
}
