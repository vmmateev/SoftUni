using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _04_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                var song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }
            string callCommand = Console.ReadLine();
            if (callCommand == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.ToString());
                }
            }
            else
            {
                foreach (var song in songs.FindAll(x => x.TypeList == callCommand))
                {
                    Console.WriteLine(song.ToString());
                }
            }
        }
    }
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
