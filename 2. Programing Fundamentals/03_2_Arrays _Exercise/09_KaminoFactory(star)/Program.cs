using System;
using System.Linq;

namespace _09_KaminoFactory_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int[] bestDnaSeq = new int[length];
            int lenghtSeq = 0;
            int bestLengthSeq = 0;
            int startingIndex = -1;
            int bestStartingIndex = 0;
            int sumSeq = 0;
            int bestSumSeq = 0;
            int currentSequenceCount = 0;
            int bestSequenceCount = 0;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] dnaSeq = command.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentSequenceCount++;
                if (length > 1)
                {
                    lenghtSeq = 0;
                    for (int i = 0; i <= dnaSeq.Length - 2; i++)
                    {
                        if (dnaSeq[i] == 1 && dnaSeq[i + 1] == 1)
                        { // longest subseq check
                            if (lenghtSeq == 0)// ako imam vhod s 1!1!1!1 vdiga starting indexa na vsqka edinica
                            {
                                startingIndex = i /*+1*/;
                            }
                            lenghtSeq++;
                            if (lenghtSeq > bestLengthSeq)    //longest subseq add
                            {
                                bestLengthSeq = lenghtSeq;
                                bestStartingIndex = startingIndex;
                                bestSequenceCount = currentSequenceCount;
                                for (int j = 0; j < dnaSeq.Length; j++)
                                {
                                    bestDnaSeq[j] = dnaSeq[j];
                                }
                                bestSumSeq = bestDnaSeq.Sum();
                            }
                            /*else*/ if (lenghtSeq == bestLengthSeq)
                            {
                                if (startingIndex < bestStartingIndex)
                                {
                                    bestStartingIndex = startingIndex;
                                    bestSequenceCount = currentSequenceCount;
                                    bestSequenceCount = currentSequenceCount;
                                    for (int j = 0; j < dnaSeq.Length; j++)
                                    {
                                        bestDnaSeq[j] = dnaSeq[j];
                                    }
                                    bestSumSeq = bestDnaSeq.Sum();
                                }
                                /*else*/ if (startingIndex == bestStartingIndex)
                                {
                                    int currenSumArray = dnaSeq.Sum();
                                    bestSequenceCount = currentSequenceCount;
                                    if (currenSumArray > bestSumSeq)
                                    {
                                        for (int j = 0; j < dnaSeq.Length; j++)
                                        {
                                            bestDnaSeq[j] = dnaSeq[j];
                                        }
                                        bestSumSeq = bestDnaSeq.Sum();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                lenghtSeq = 0;
                            }
                        }
                    }
                }
                else
                {
                    if (length == 1)
                    {

                        if (int.Parse(command) > 0)
                        {
                            bestSequenceCount = 1;
                            bestDnaSeq[0] = int.Parse(command);
                            bestSumSeq = 1;

                        }
                        else if (int.Parse(command) == 0)
                        {
                            if (bestStartingIndex == 0)
                            {

                                bestSequenceCount = 0;
                                bestDnaSeq[0] = int.Parse(command);
                                bestSumSeq = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceCount} with sum: {bestSumSeq}.");
            Console.WriteLine(string.Join(" ", bestDnaSeq));
        }
    }
}


