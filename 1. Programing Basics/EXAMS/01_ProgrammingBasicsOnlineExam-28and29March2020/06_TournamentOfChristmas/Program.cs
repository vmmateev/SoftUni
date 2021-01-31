using System;

namespace _06_TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string sportType = "";
            double totalSumWin = 0;
            double dailySumWin = 0;
            int dayWinCount = 0;
            int dayLoseCount = 0;
            int winCount = 0;
            int loseCount = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                dailySumWin = 0;
                winCount = 0;
                loseCount = 0;
                while ((sportType = Console.ReadLine()) != "Finish")
                {
                    string condition = Console.ReadLine();
                    if (condition == "win")
                    {
                        dailySumWin += 20;
                        winCount++;
                    }
                    else if (condition == "lose")
                    {
                        loseCount++;
                    }
                }

                if (winCount > loseCount)
                {
                    dailySumWin = dailySumWin * 1.1;
                    dayWinCount++;
                }
                else if (winCount < loseCount)
                {
                    dayLoseCount++;
                }
                totalSumWin += dailySumWin;
            }
            if (dayWinCount > dayLoseCount)
            {
                totalSumWin = totalSumWin * 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSumWin:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSumWin:f2}");
            }
        }
    }
}
