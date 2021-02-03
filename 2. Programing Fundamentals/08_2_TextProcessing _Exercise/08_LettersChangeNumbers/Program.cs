using System;

namespace _08_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = input[i];
                char firstChar = currentElement[0];
                char lastChar = currentElement[currentElement.Length - 1];
                double numberMiddle = int.Parse(currentElement.Substring(1, currentElement.Length - 2));
                int firstPos = PositionOfLetter(firstChar);
                int secondPos = PositionOfLetter(lastChar);
                
                if (firstChar >= 'A' && firstChar <= 'Z')
                {
                    numberMiddle /= firstPos;
                }
                else if (firstChar >= 'a' && firstChar <= 'z')
                {
                    numberMiddle *= firstPos;
                }
                // Second Letter
               
                if (lastChar >= 'A' && lastChar <= 'Z')
                {
                    numberMiddle -= secondPos;
                }
                else if (lastChar >= 'a' && lastChar <= 'z')
                {
                    numberMiddle += secondPos;
                }
                
                sum += numberMiddle;
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static int PositionOfLetter(char Letter)
        {
            return (int)Letter % 32;
        }
    }
}
//First you start with the letter before the number. 
//•	If it's uppercase you divide the number by the letter's position in the alphabet. 
//•	If it's lowercase you multiply the number with the letter's position in the alphabet. 
//Then you move to the letter after the number. 
//•	If it's uppercase you subtract its position from the resulted number.
//•	If it's lowercase you add its position to the resulted number.
