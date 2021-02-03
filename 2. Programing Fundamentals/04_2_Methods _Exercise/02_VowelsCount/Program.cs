using System;

namespace _02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowelCounter(input));
        }
        static int VowelCounter(string word)
        {
            int counter = 0; //softuni
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'o' || word[i] == 'e' || word[i] == 'u' || word[i] == 'i')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
