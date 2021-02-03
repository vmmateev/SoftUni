using System;

namespace _03_RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i==0||i==1)
                {
                    array[i] = 1;
                }
                else if (i==2)
                {
                    array[i] = 2;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
                result = array[array.Length - 1];
            }

            Console.WriteLine(result);
        }
    }
}
