using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace _8_AnonymousThreat_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> input = Console.ReadLine().Split().ToList();
            //string command = Console.ReadLine();
            //while (command != "3:1")
            //{
            //    List<string> tokens = command.Split().ToList();
            //    if (tokens[0] == "merge")
            //    {
            //        int startIndex = int.Parse(tokens[1]);
            //        int endIndex = int.Parse(tokens[2]);
            //        if (startIndex < 0)
            //        {
            //            startIndex = 0;
            //        }
            //        else if (startIndex > input.Count - 1)
            //        {
            //            startIndex = input.Count - 1;
            //        }
            //        if (endIndex < 0)
            //        {
            //            endIndex = 0;
            //        }
            //        else if (endIndex > input.Count - 1)
            //        {
            //            endIndex = input.Count - 1;
            //        }
            //        List<string> temp = new List<string>();
            //        for (int i = startIndex; i <= endIndex; i++)
            //        {

            //            temp.Add(input[i]);
            //        }
            //        input[startIndex] = string.Join("", temp);
            //        for (int i = startIndex + 1; i <= endIndex; i++)
            //        {
            //            input.RemoveAt(startIndex + 1);

            //        }
            //    }
            //    else if (tokens[0] == "divide")
            //    {
            //        List<string> temp = new List<string>();
            //        string toDivide = input[int.Parse(tokens[1])];
            //        int partitions = int.Parse(tokens[2]);
            //        int partLength = toDivide.Length / int.Parse(tokens[2]);
            //        int additionalPartLength = toDivide.Length % int.Parse(tokens[2]);
            //        for (int i = 0; i < partitions; i++)
            //        {
            //            if (i == partitions - 1) partLength += additionalPartLength;
            //            temp.Add(toDivide.Substring(0, partLength));
            //            toDivide = toDivide.Remove(0, partLength);
            //        }
            //        input.RemoveAt(int.Parse(tokens[1]));
            //        input.InsertRange(int.Parse(tokens[1]), temp);
            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine(string.Join(" ", input));

            // reshenie ot Sanya Kasarova
            List<string> input = Console.ReadLine().Split().ToList();
            string[] commands = Console.ReadLine().Split().ToArray();
            List<string> divideList = new List<string>();
            string word = string.Empty;
            while (commands[0] != "3:1")
            {
                List<string> output = new List<string>();
                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex < 0)                     // Проверка на индексите понеже при всяка итерация размера на листа се променя динамично 
                    {
                        if (endIndex >= 0 && endIndex <= input.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex > input.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= input.Count - 1)
                        {

                            endIndex = input.Count - 1;
                        }
                    }
                    if ((startIndex >= 0 && startIndex <= input.Count - 1) && (endIndex >= 0 && endIndex <= input.Count - 1))
                    {
                        word = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            word += input[i];
                        }
                        input.RemoveRange(startIndex, endIndex - startIndex + 1);
                        input.Insert(startIndex, word);
                    }
                }

                else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                    if (index >= 0 && index <= input.Count - 1)
                    {
                        word = input[index];
                        int stringLengthToAdd = word.Length / partitions;
                        int additionalLength = word.Length % partitions; // novo
                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1) // ako sme na poslednata iteraciq da dobavqme vsi4ki ostanali elementi na dumata
                            {
                                divideList.Add(word.Substring(startIndex, word.Length - startIndex + additionalLength));
                            }
                            else
                            {
                                divideList.Add(word.Substring(startIndex, stringLengthToAdd));
                                startIndex += stringLengthToAdd;
                            }
                        }
                        input.RemoveAt(index);
                        input.InsertRange(index, divideList);
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}