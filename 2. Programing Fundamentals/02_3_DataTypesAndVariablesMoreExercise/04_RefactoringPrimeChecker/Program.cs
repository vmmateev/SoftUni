using System;

namespace _04_RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ___Do___ = int.Parse(Console.ReadLine());
            //for (int takoa = 2; takoa <= ___Do___; takoa++)
            //{
            //    bool takovalie = true;
            //    for (int cepitel = 2; cepitel < takoa; cepitel++)
            //    {
            //        if (takoa % cepitel == 0)
            //        {
            //            takovalie = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine("{0} -> {1}", takoa, takovalie);
            //}

            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int dividier = 2; dividier < i; dividier++)
                {
                    if (i % dividier == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }
        }
    }
}
