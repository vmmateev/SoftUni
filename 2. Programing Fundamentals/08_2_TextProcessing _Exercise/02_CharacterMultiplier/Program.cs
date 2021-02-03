using System;

namespace _02_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string str1 = str[0];
            string str2 = str[1];
            int sum = CharsSum(str1, str2);
            Console.WriteLine(sum);
        }

        private static int CharsSum(string str1, string str2)
        {
            int maxLength = Math.Max(str1.Length, str2.Length);
            int minLenght = Math.Min(str1.Length, str2.Length);
                        int sum = 0;
            for (int i = 0; i < minLenght; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (str1.Length != str2.Length)
            {
                string bigerString = str1.Length > str2.Length ? bigerString = str1 : bigerString = str2;
                for (int i = minLenght; i < maxLength; i++)
                {
                    sum += bigerString[i];
                }
            }
            return sum;
        }
    }
}
