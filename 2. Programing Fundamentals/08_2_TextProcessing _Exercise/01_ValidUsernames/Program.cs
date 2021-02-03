using System;
using System.Linq;

namespace _01_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            foreach (var item in input.Where(x => x.Length > 2 && x.Length < 17))
            {
                bool IsValidUserName = false;
                for (int i = 0; i < item.Length; i++)
                {
                    char currentSymb = item[i];
                    if (char.IsLetterOrDigit(currentSymb)|| currentSymb == '-' || currentSymb == '_')
                    {
                        IsValidUserName = true;
                    }
                    else
                    {
                        IsValidUserName = false;
                        break;
                    }
                }
                if (IsValidUserName)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
