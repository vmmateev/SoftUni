using System;
using System.Dynamic;
using System.Collections;
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace _02_Articles
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ").ToList();
            int count = int.Parse(Console.ReadLine());
            var Statiq = new Article() { Title = input[0], Content = input[1], Author = input[2] };

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(":").Select(str => str.Trim()).ToArray();

                if (command[0]=="Edit")
                {
                    Statiq.Edit(command[1]);
                }
                else if (command[0] =="ChangeAuthor")
                {
                    Statiq.ChangeAuthor(command[1]);
                }
                else if (command[0]=="Rename")
                {
                    Statiq.Rename(command[1]);
                }
            }
            Console.WriteLine(Statiq.ToString());
            
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string NewContent)
        {
            Content = NewContent;
        }

        public void ChangeAuthor(string NewAuthor)
        {
            Author = NewAuthor;
        }

        public void Rename(string NewTitle)
        {
            Title = NewTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}


