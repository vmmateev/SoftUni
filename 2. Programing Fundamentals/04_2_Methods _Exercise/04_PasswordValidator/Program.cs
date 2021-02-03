using System;
using System.Linq;

namespace _04_PasswordValidator
{
    class Program
    {
        static bool isValid = true;
        public static void Main()
        {
            string password = Console.ReadLine();
            CheckIfPasswordIs6to10Chars(password);
            CheckIfPasswordConsistLettersAndDigitsOnly(password);
            CheckIfPasswordMoreThan2Digits(password);
            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        public static void CheckIfPasswordIs6to10Chars(string password)
        {
            int lenghtOfPassword = password.Length;

            if (lenghtOfPassword >= 6 && lenghtOfPassword <= 10)
            {
                //isValid = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
        }
        public static void CheckIfPasswordConsistLettersAndDigitsOnly(string password)
        {
            char[] letters = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if ((letters[i] >= 48 && letters[i] <= 57) || (letters[i] >= 65 && letters[i] <= 90) || (letters[i] >= 97 && letters[i] <= 122))
                {
                    //isValid = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
        }
        public static void CheckIfPasswordMoreThan2Digits(string password)
        {
            char[] letters = password.ToCharArray();
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (letters[i] >= 48 && letters[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                //isValid = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
        }
    }
}

