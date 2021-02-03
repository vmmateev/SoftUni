using System;
using System.Linq;
using System.Security.Authentication;
using System.Collections;

namespace _11_ArrayManipulator_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                if (input[0] == "exchange")
                {
                    int rotationIndex = int.Parse(input[1]);
                    if (rotationIndex < 0 || rotationIndex >= numbersArray.Length) // da mahna ravenostvoto pri daljinata na masiva !!!!!! ili pyk ne 
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {       // index 2 lenght 0 1 2 3 4
                        int[] leftArr = new int[rotationIndex + 1];
                        int[] rightArr = new int[numbersArray.Length - leftArr.Length];
                        Array.Copy(numbersArray, leftArr, rotationIndex + 1);
                        Array.Copy(numbersArray, rotationIndex + 1, rightArr, 0, rightArr.Length);
                        //Console.WriteLine("left " + string.Join(' ',leftArr));
                        //Console.WriteLine("right " + string.Join(' ',rightArr));
                        Array.Copy(rightArr, numbersArray, rightArr.Length);
                        Array.Copy(leftArr, 0, numbersArray, rightArr.Length, leftArr.Length);
                        //Console.WriteLine("new array " + string.Join(' ',numbersArray));
                        //int[] copyArray = new int[numbersArray.Length];
                        //copyArray = numbersArray;
                        //for (int i = 0; i < rotationIndex; i++)

                        //{
                        //    int temp = numbersArray[0];
                        //    for (int j = 0; j < numbersArray.Length - 1; j++)
                        //    {
                        //        //2 3 4 5 
                        //        // 1 2 3 4 5
                        //        numbersArray[j] = copyArray[j + 1];

                        //    }
                        //    numbersArray[numbersArray.Length - 1] = temp;
                        //}
                        //Console.WriteLine(string.Join(" ", numbersArray));
                    }
                }
                else if (input[0] == "max")
                {
                    if (input[1] == "even")
                    {
                        int maxEven = int.MinValue;
                        int evenIndex = -1;
                        for (int i = 0; i < numbersArray.Length; i++)
                        {
                            if (numbersArray[i] % 2 == 0 && numbersArray[i] >= maxEven)
                            {
                                maxEven = numbersArray[i];
                                evenIndex = i;
                            }
                        }
                        if (evenIndex > -1)
                        {
                            Console.WriteLine(evenIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (input[1] == "odd")
                    {
                        int maxOdd = int.MinValue;
                        int oddIndex = -1;
                        for (int i = 0; i < numbersArray.Length; i++)
                        {
                            if (numbersArray[i] % 2 != 0 && numbersArray[i] >= maxOdd)
                            {
                                maxOdd = numbersArray[i];
                                oddIndex = i;
                            }
                        }
                        if (oddIndex > -1)
                        {
                            Console.WriteLine(oddIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (input[0] == "min")
                {
                    if (input[1] == "even")
                    {
                        int minEven = int.MaxValue;
                        int evenIndex = -1;
                        for (int i = 0; i < numbersArray.Length; i++)
                        {
                            if (numbersArray[i] % 2 == 0 && numbersArray[i] <= minEven)
                            {
                                minEven = numbersArray[i];
                                evenIndex = i;
                            }
                        }
                        if (evenIndex > -1)
                        {
                            Console.WriteLine(evenIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (input[1] == "odd")
                    {
                        int minOdd = int.MaxValue;
                        int oddIndex = -1;
                        for (int i = 0; i < numbersArray.Length; i++)
                        {
                            if (numbersArray[i] % 2 != 0 && numbersArray[i] <= minOdd)
                            {
                                minOdd = numbersArray[i];
                                oddIndex = i;
                            }
                        }
                        if (oddIndex > -1)
                        {
                            Console.WriteLine(oddIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (input[0] == "first")
                {
                    int countElements = int.Parse(input[1]);
                    int countElements2 = countElements;
                    int arrayIndexCounter = 0;
                    if (countElements > numbersArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string firstEvenElements = "";
                        string firstOddElement = "";

                        if (input[2] == "even")
                        {
                            for (int j = 0; j < numbersArray.Length; j++)
                            {
                                if (countElements > 0 && numbersArray[j] % 2 == 0)
                                {
                                    firstEvenElements += numbersArray[j];
                                    countElements--;
                                }
                            }
                            if (firstEvenElements != "")
                            {
                                //int[] firstEvenElementsArray = new int[arrayIndexCounter];

                                //for (int i = 0; i < firstEvenElements.Length; i++)
                                //{
                                //    if (countElements2 > 0 && numbersArray[i] % 2 == 0)
                                //    {
                                //    firstEvenElementsArray[i] = firstEvenElements[i];
                                //        countElements2--;
                                //    }
                                //}
                                int newLenght = 0;
                                for (int i = 0; i < numbersArray.Length; i++)
                                {
                                    if (numbersArray[i] != 0&& numbersArray[i]%2==0)
                                    {
                                        newLenght++;
                                    }
                                }
                                if (countElements<newLenght)
                                {
                                    newLenght = countElements2;
                                }
                                int[] newArrayWithoutZeros = new int[newLenght];
                                for (int i = 0, j = 0; i < numbersArray.Length; i++)
                                {
                                    if (numbersArray[i] != 0 && numbersArray[i] % 2 == 0)
                                    {
                                        newArrayWithoutZeros[j] = numbersArray[i];
                                        j++;
                                        countElements2--;
                                        if (countElements2==0)
                                        {
                                            break;
                                        }
                                    }
                                }


                                Console.WriteLine("[" + string.Join(", ", string.Join(", ", newArrayWithoutZeros) + "]"));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                        else if (input[2] == "odd")
                        {
                            for (int j = 0; j < numbersArray.Length; j++)
                            {
                                if (numbersArray[j] % 2 != 0 && countElements > 0)
                                {
                                    firstOddElement += numbersArray[j];
                                    countElements--;
                                }
                            }
                            if (firstOddElement != "")
                            {
                                //char[] firstOddElementsArray = new char[firstOddElement.Length];

                                //for (int i = 0; i < firstOddElement.Length; i++)
                                //{
                                //    firstOddElementsArray[i] = firstOddElement[i];
                                //}
                                int newLenght = 0;
                                for (int i = 0; i < numbersArray.Length; i++)
                                {
                                    if (numbersArray[i] != 0 && numbersArray[i] % 2 != 0)
                                    {
                                        newLenght++;
                                    }
                                }
                                if (countElements < newLenght)
                                {
                                    newLenght = countElements2;
                                }
                                int[] newArrayWithoutZeros = new int[newLenght];
                                for (int i = 0, j = 0; i < numbersArray.Length; i++)
                                {
                                    if (numbersArray[i] != 0 && numbersArray[i] % 2 != 0)
                                    {
                                        newArrayWithoutZeros[j] = numbersArray[i];
                                        j++;
                                        countElements2--;
                                        if (countElements2 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                                Console.WriteLine("[" + string.Join(", ", string.Join(", ", newArrayWithoutZeros) + "]"));
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }
                        }
                    }
                }
                else if (input[0] == "last")
                {
                    int countElements = int.Parse(input[1]);
                    int countElements2 = countElements;
                    string firstEvenElements = "";
                    string firstOddElements = "";
                    if (input[2] == "even")
                    {
                        for (int j = 0; j < numbersArray.Length; j++)
                        {
                            if (numbersArray[j] % 2 == 0 && countElements > 0)
                            {
                                firstEvenElements += numbersArray[j];
                                countElements--;
                            }
                        }
                        if (firstEvenElements != "")
                        {
                            //char[] firstEvenElementsArray = new char[firstEvenElements.Length];

                            //for (int i = 0; i < firstEvenElements.Length; i++)
                            //{
                            //    firstEvenElementsArray[i] = firstEvenElements[i];
                            //}
                            int newLenght = 0;
                            for (int i = 0; i < numbersArray.Length; i++)
                            {
                                if (numbersArray[i] != 0 && numbersArray[i] % 2 == 0)
                                {
                                    newLenght++;
                                }
                            }
                            if (countElements < newLenght)
                            {
                                newLenght = countElements2;
                            }
                            int[] newArrayWithoutZeros = new int[newLenght];
                            for (int i = 0, j = 0; i < numbersArray.Length; i++)
                            {
                                if (numbersArray[i] != 0 && numbersArray[i] % 2 == 0)
                                {
                                    newArrayWithoutZeros[j] = numbersArray[i];
                                    j++;
                                    countElements2--;
                                    if (countElements2 == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("[" + string.Join(", ", string.Join(", ", newArrayWithoutZeros) + "]"));

                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else if (input[2] == "odd")
                    {
                        for (int j = 0; j < numbersArray.Length; j++)
                        {
                            if (numbersArray[j] % 2 != 0 && countElements > 0)
                            {
                                firstOddElements += numbersArray[j];
                                countElements--;
                            }
                        }
                        if (firstOddElements != "")
                        {
                            //char[] firstOddElementsArray = new char[firstOddElements.Length];

                            //for (int i = 0; i < firstOddElements.Length; i++)
                            //{
                            //    firstOddElementsArray[i] = firstOddElements[i];
                            //}
                            int newLenght = 0;
                            for (int i = 0; i < numbersArray.Length; i++)
                            {
                                if (numbersArray[i] != 0 && numbersArray[i] % 2 != 0)
                                {
                                    newLenght++;
                                }
                            }
                            if (countElements < newLenght)
                            {
                                newLenght = countElements2;
                            }
                            int[] newArrayWithoutZeros = new int[newLenght];
                            for (int i = 0, j = 0; i < numbersArray.Length; i++)
                            {
                                if (numbersArray[i] != 0 && numbersArray[i] % 2 != 0)
                                {
                                    newArrayWithoutZeros[j] = numbersArray[i];
                                    j++;
                                    countElements2--;
                                    if (countElements2 == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("[" + string.Join(", ", string.Join(", ", newArrayWithoutZeros) + "]"));

                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
                else if (input[0] == "print") // additional implementation for easy life
                {
                    Console.WriteLine("[" + string.Join(", ", numbersArray) + "]");

                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbersArray) + "]");
        }
    }
}


//namespace P11_ArrayManipulator
//{
//    using System;
//    using System.Linq;

//    class P11_ArrayManipulator
//    {
//        static void Main(string[] args)
//        {
//            int[] initialArray = Console.ReadLine()
//                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                                        .Select(int.Parse)
//                                        .ToArray();

//            string[] command = Console.ReadLine().Split();

//            while (command[0] != "end")
//            {
//                string message = string.Empty;
//                switch (command[0])
//                {
//                    case "exchange":
//                        Exchange(initialArray, command);
//                        command = Console.ReadLine().Split();
//                        continue;

//                    case "max":
//                        int index = Max(initialArray, command);
//                        message = (index >= 0) ? $"{index}" : "No matches";
//                        break;

//                    case "min":
//                        index = Min(initialArray, command);
//                        message = (index >= 0) ? $"{index}" : "No matches";
//                        break;

//                    case "first":
//                        int count = int.Parse(command[1]);
//                        if (count > initialArray.Length)
//                        {
//                            message = "Invalid count";
//                            break;
//                        }

//                        string evenOrOdd = command[2];
//                        int[] nums = First(initialArray, count, evenOrOdd);

//                        message = (nums.Length == 0 ? "[]" : $"[{String.Join(", ", nums)}]");
//                        break;

//                    case "last":
//                        count = int.Parse(command[1]);
//                        if (count > initialArray.Length)
//                        {
//                            message = "Invalid count";
//                            break;
//                        }

//                        evenOrOdd = command[2];
//                        nums = Last(initialArray, count, evenOrOdd);
//                        message = (nums.Length == 0 ? "[]" : $"[{String.Join(", ", nums)}]");
//                        break;
//                }

//                Console.WriteLine(message);
//                command = Console.ReadLine().Split();
//            }

//            Console.WriteLine($"[{String.Join(", ", initialArray)}]");
//        }

//        public static void Exchange(int[] initialArray, string[] command)
//        {
//            int index = int.Parse(command[1]);
//            if (index < 0 || index >= initialArray.Length)
//            {
//                Console.WriteLine("Invalid index");
//                return;
//            }

//            int[] leftSide = new int[index + 1];
//            int[] rightSide = new int[initialArray.Length - 1 - index];
//            int counter = 0;

//            for (int i = 0; i < initialArray.Length; i++)
//            {
//                if (i < leftSide.Length)
//                {
//                    leftSide[i] = initialArray[i];
//                }
//                else
//                {
//                    rightSide[counter] = initialArray[i];
//                    counter++;
//                }
//            }

//            counter = 0;
//            for (int i = 0; i < initialArray.Length; i++)
//            {
//                if (i < rightSide.Length)
//                {
//                    initialArray[i] = rightSide[i];
//                }
//                else
//                {
//                    initialArray[i] = leftSide[counter++];
//                }
//            }
//        }

//        public static int Max(int[] initialArray, string[] command)
//        {
//            int max = int.MinValue;
//            int index = -1;

//            switch (command[1])
//            {
//                case "even":
//                    for (int i = 0; i < initialArray.Length; i++)
//                    {
//                        if (initialArray[i] % 2 == 0 && initialArray[i] >= max)
//                        {
//                            max = initialArray[i];
//                            index = i;
//                        }
//                    }

//                    break;

//                case "odd":
//                    for (int i = 0; i < initialArray.Length; i++)
//                    {
//                        if (initialArray[i] % 2 != 0 && initialArray[i] >= max)
//                        {
//                            max = initialArray[i];
//                            index = i;
//                        }
//                    }

//                    break;
//            }

//            return index;
//        }

//        public static int Min(int[] initialArray, string[] command)
//        {
//            int min = int.MaxValue;
//            int index = -1;
//            switch (command[1])
//            {
//                case "even":
//                    for (int i = 0; i < initialArray.Length; i++)
//                    {
//                        if (initialArray[i] % 2 == 0 && initialArray[i] <= min)
//                        {
//                            min = initialArray[i];
//                            index = i;
//                        }
//                    }

//                    break;

//                case "odd":
//                    for (int i = 0; i < initialArray.Length; i++)
//                    {
//                        if (initialArray[i] % 2 != 0 && initialArray[i] <= min)
//                        {
//                            min = initialArray[i];
//                            index = i;
//                        }
//                    }

//                    break;
//            }

//            return index;
//        }

//        public static int[] First(int[] initialArray, int count, string evenOrOdd)
//        {
//            string nums = string.Empty;
//            switch (evenOrOdd)
//            {
//                case "even":
//                    foreach (int digit in initialArray)
//                    {
//                        if (count > 0 && digit % 2 == 0)
//                        {
//                            nums += $"{digit} ";
//                            count--;
//                        }
//                    }
//                    break;

//                case "odd":
//                    foreach (int digit in initialArray)
//                    {
//                        if (count > 0 && digit % 2 != 0)
//                        {
//                            nums += $"{digit} ";
//                            count--;
//                        }
//                    }
//                    break;
//            }
//            nums.TrimEnd();

//            return nums.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                       .Select(int.Parse)
//                       .ToArray();
//        }

//        public static int[] Last(int[] initialArray, int count, string evenOrOdd)
//        {
//            string nums = string.Empty;
//            switch (evenOrOdd)
//            {
//                case "even":
//                    for (int i = initialArray.Length - 1; i >= 0; i--)
//                    {
//                        if (count > 0 && initialArray[i] % 2 == 0)
//                        {
//                            nums += $"{initialArray[i]} ";
//                            count--;
//                        }
//                    }
//                    break;

//                case "odd":
//                    for (int i = initialArray.Length - 1; i >= 0; i--)
//                    {
//                        if (count > 0 && initialArray[i] % 2 != 0)
//                        {
//                            nums += $"{initialArray[i]} ";
//                            count--;
//                        }
//                    }
//                    break;
//            }
//            nums.TrimEnd();

//            return nums.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                       .Select(int.Parse)
//                       .ToArray()
//                       .Reverse()
//                       .ToArray();
//        }
//    }
//}