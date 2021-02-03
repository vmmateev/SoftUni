using System;
using System.Reflection.Metadata;

namespace _09_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetMaxValue(int.Parse(first), int.Parse(second)));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMaxValue(char.Parse(first), char.Parse(second)));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMaxValue(first, second));
            }
        }

        static int GetMaxValue(int num1, int num2)
        {
            int result = 0; ;
            if (num1 >= num2)
            {
                result = num1;
            }
            else if (num2 > num1)
            {
                result = num2;
            }
            return result;
        }
        static char GetMaxValue(char num1, char num2)
        {
            int result=0 ;
            if (num1 >= num2)
            {
                result = num1;
            }
            else if (num2 > num1)
            {
                result = num2;
            }
            return (char)result;
        }
        static string GetMaxValue(string num1, string num2)
        {
            if (num1.CompareTo(num2)>=0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
            //int firstStringSum = 0;
            //int secondStringSum = 0;
            //string result = "";
            //for (int i = 0; i < num1.Length; i++)
            //{
            //    firstStringSum += num1[i];
            //}
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    secondStringSum += num2[i];
            //}
            //if (firstStringSum >= secondStringSum)
            //{
            //    result = num1;
            //}
            //else if (secondStringSum > firstStringSum)
            //{
            //    result = num2;
            //}
            //return result;
        }
    }
}
