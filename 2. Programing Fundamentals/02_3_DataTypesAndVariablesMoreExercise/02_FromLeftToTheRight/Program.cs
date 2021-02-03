using System;

namespace _02_FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string text = Console.ReadLine();
                string first = "";
                string second = "";
                for (int j = 0; j < text.Length - 1; j++)
                {
                    first += text[j];
                    bool isSpace = text[j].ToString() == " ";
                    if (isSpace)
                    {
                        for (int l = j + 1; l < text.Length; l++)
                        {
                            second += text[l];
                        }
                        break;
                    }
                }
                long numberFirst = long.Parse(first);
                long numberSecond = long.Parse(second);
                long sumToPrint = 0;

                if (numberFirst > numberSecond)
                {
                    for (int m = 0; m < first.Length; m++)
                    {
                        sumToPrint += numberFirst % 10;
                        numberFirst /= 10;
                    }
                }
                else
                {
                    for (int n = 0; n < second.Length; n++)
                    {
                        sumToPrint += numberSecond % 10;
                        numberSecond /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sumToPrint));
            }
        }
    }
}
