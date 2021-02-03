using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingDict = new Dictionary<string, string>();
            int numberCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string username = commands[1];
                if (commands[0] == "register")
                {
                    string plate = commands[2];
                    if (parkingDict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingDict[username]}");
                    }
                    else
                    {
                        parkingDict.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                }
                else if (commands[0] == "unregister")
                {
                    if (!parkingDict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingDict.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }

                }
            }
            foreach (var user in parkingDict)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
