using System;
using System.Linq;

namespace _03_ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            string[] firstArr = new string[loop];
            string[] secondArr = new string[loop];

            for (int i = 0; i < loop; i++)
            {
                string[] tempArray = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    firstArr[i] = tempArray[0];
                    secondArr[i] = tempArray[1];
                }
                else
                {
                    firstArr[i] = tempArray[1];
                    secondArr[i] = tempArray[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
