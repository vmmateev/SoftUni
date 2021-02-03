using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            List<int> tempResult = new List<int>();

            List<int> workList = new List<int>();
            secondInput.Reverse();
            if (firstInput.Count > secondInput.Count)
            {
                workList = firstInput;
            }
            else
            {
                workList = secondInput;
            }

            int startElement = workList[workList.Count - 2];
            int endElement = workList[workList.Count - 1];

            for (int i = 0; i < workList.Count - 2; i++)
            {
                result.Add(firstInput[i]);
                result.Add(secondInput[i]);
            }

            int startNumber = workList[workList.Count - 2];
            int EndNumber = workList[workList.Count - 1];
            foreach (var number in result)
            {

                if (number > Math.Min(startElement, endElement) && number < Math.Max(startElement, endElement))
                {
                    tempResult.Add(number);
                }
            }
            tempResult.Sort();
            foreach (var resultItem in tempResult)
            {
                Console.Write(resultItem + " ");
            }

            //List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            //List<int> result = new List<int>();
            //List<int> tempResult = new List<int>();
            //List<int> bordersList = new List<int>();


            //secondInput.Reverse(); // ЗАРАДИ ТОВА понеже условието е да вземеш за гранници елементите които остават , а когато добавяш втория лист взимаш отзад напред и ако той е по големия оставащите елементи са първите два .... ! аман 
            //if (firstInput.Count > secondInput.Count)
            //{
            //    bordersList.Add(firstInput[firstInput.Count - 2]);
            //    bordersList.Add(firstInput[firstInput.Count - 1]);
            //    firstInput.RemoveRange(firstInput.Count-2, 2);
            //}
            //else
            //{  
            //    bordersList.Add(secondInput[secondInput.Count - 2]);
            //    bordersList.Add(secondInput[secondInput.Count - 1]);
            //    secondInput.RemoveRange(secondInput.Count - 2, 2);
            //}
            //bordersList.Sort();
            //for (int i = 0; i < firstInput.Count; i++) // няма значение от каунта на кой лист понеже вече са еднакви
            //{
            //    result.Add(firstInput[i]);
            //    result.Add(secondInput[i]);
            //}

            //for (int i = 0; i < result.Count; i++)
            //{
            //    if (result[i] > bordersList[0] && result[i] < bordersList[1])
            //    {
            //        tempResult.Add(result[i]);
            //    }
            //}
            //tempResult.Sort();
            //Console.WriteLine(string.Join(" ", tempResult));
        }
    }
}
