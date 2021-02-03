using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ForceBook_star_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsersDict = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                var commands = input.Split().ToList();
                string tempSide;
                bool isThereThatUser;
                if (input.Contains(" | ")) // forceSIDE | forceUSER
                {
                    string[] tokens = input.Split(" | ");
                    string user = tokens[1];
                    string side = tokens[0];
                    // Dobavka foreach
                    UserCheck(forceUsersDict, out tempSide, out isThereThatUser, user);
                    //dobavka do tuk
                    if (forceUsersDict.ContainsKey(side)) // Ako ima strana 
                    {
                        if (!forceUsersDict[side].Contains(user) && !isThereThatUser)
                        {
                            forceUsersDict[side].Add(user);
                        }
                    }
                    else if (!isThereThatUser) // Ako nqma takava strana dobavqme i stranata i user-a
                    {
                        forceUsersDict.Add(side, new List<string>() { user });
                    }
                }
                else if (input.Contains(" -> ")) // forceUSER -> forceSIDE
                {
                    string[] tokens = input.Split(" -> ");
                    string user = tokens[0];
                    string side = tokens[1];
                    UserCheck(forceUsersDict, out tempSide, out isThereThatUser, user); // Ima li takav user po drugite strani 
                    if (forceUsersDict.ContainsKey(side)) // Ako ime takava strana v rechnika
                    {
                        if (isThereThatUser)
                        {
                            forceUsersDict[tempSide].Remove(user);
                            forceUsersDict[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                        else
                        {
                            forceUsersDict[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else // ako nqma takava strana v rechnika
                    {
                        if (isThereThatUser)
                        {
                            forceUsersDict[tempSide].Remove(user);
                            forceUsersDict.Add(side, new List<string>() { user });
                        }
                        else
                        {
                            forceUsersDict.Add(side, new List<string>() { user });
                        }
                            Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }
            foreach (var side in forceUsersDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).Where(x => x.Value.Count > 0))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
        private static void UserCheck(Dictionary<string, List<string>> forceUsersDict, out string tempSide, out bool isThereThatUser, string user)
        {
            tempSide = string.Empty;
            isThereThatUser = false; // Ima li takav user po drugite strani 
            foreach (var item in forceUsersDict)
            {
                if (item.Value.Contains(user))
                {
                    tempSide = item.Key;
                    isThereThatUser = true;
                }
            }
        }
    }
}
