using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerPos = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string player = input.Split(" -> ", 3)[0];
                    string position = input.Split(" -> ", 3)[1];
                    int skill = int.Parse(input.Split(" -> ", 3)[2]);

                    if (playerPos.ContainsKey(player))
                    {
                        if (playerPos[player].ContainsKey(position))
                        {
                            if (playerPos[player][position] < skill)
                            {
                                playerPos[player][position] = skill;
                            }
                        }
                        else
                        {
                            playerPos[player].Add(position, skill);
                        }
                    }
                    else
                    {
                        playerPos.Add(player, new Dictionary<string, int>() { { position, skill } });
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string player1 = input.Split(" vs ", 2)[0];
                    string player2 = input.Split(" vs ", 2)[1];
                    if (playerPos.ContainsKey(player1) && playerPos.ContainsKey(player2))
                    {
                        string playerToRemove = "";
                        foreach (var first in playerPos[player1])
                        {
                            foreach (var second in playerPos[player2])
                            {
                                if (first.Key == second.Key)
                                {
                                    if (playerPos[player1].Values.Sum() > playerPos[player2].Values.Sum())
                                    {
                                        playerToRemove = player2; //Ако търкам директно тук последните 2 теста гърмят с Runtime
                                    }
                                    else if (playerPos[player1].Values.Sum() < playerPos[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                            }
                        }
                        playerPos.Remove(playerToRemove); //Това решава проблема с триенето директно в 
                    }
                }
            }
            foreach (var player in playerPos.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- { position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
