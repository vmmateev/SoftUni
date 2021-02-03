using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Article20
{
    class Program
    {
        static void Main(string[] args)
        {                                                                            //
            var articles = new List<Article>();                                      // Дефинираме Лист от обекти Article с име articles
            int count = int.Parse(Console.ReadLine());                               //
                                                                                     //
            for (int i = 0; i < count; i++)                                          //
            {                                                                        //
                var commands = Console.ReadLine().Split(", ").ToArray();             //
                                                                                     //
                string title = commands[0];                                          // Създаваме нови променливи към който присвояваме входа от конзолата да съответства на title content author
                string content = commands[1];                                        //
                string author = commands[2];                                         //
                                                                                     //
                var article = new Article(title, content, author);                   //  създаваме нов обект със съответните атрибути със същите имена като в Класа и присвояваме създадените по горе към тях така че да си отговарвят
                                                                                     //  Вече имаме един Обект статия със добавени съответните атрибути Заглавие Съдържание и Автор
                articles.Add(article);                                               // Добавяме обекта с име article към листа articles
            }                                                                        //
            string order = Console.ReadLine();                                       // четем по какво искаме да сортираме листовете
            if (order=="title")                                                      //
            {                                                                        //
                articles = articles.OrderBy(x => x.Title).ToList();                  // сортираме листа 
            }                                                                        //
            else if (order=="content")                                               //
            {                                                                        //
                articles = articles.OrderBy(x => x.Content).ToList();                //
            }                                                                        //
            else if (order =="author")                                               //
            {                                                                        //
                articles = articles.OrderBy(x => x.Author).ToList();                 //
            }                                                                        //
                                                                                     //
            Console.WriteLine(string.Join(Environment.NewLine, articles));           //
        }

        public class Article                                                   // Дефинираме клас който е публичен
        {                                                                      //
            public Article(string title, string content, string author)        // дефинира се ОБЕКТ със 3 стрингови полета с съответните заглавия Title Content и Author
            {                                                                  //
                Title = title;                                                 // Свързва се променливата title която идва извън класа така че да се присвой към Title променливата която е атрибут на Класа
                Content = content;                                             //
                Author = author;                                               //
            }                                                                  //
            public string Title { get; set; }                                  // Гетъри и Сетъри за всички атрибути на класа
            public string Content { get; set; }                                //
            public string Author { get; set; }                                 //
                                                                               //
            public override string ToString()                                  // Заместващ метод за ToString Метода
            {                                                                  //
                return $"{Title} - {Content}: {Author}";                       //
            }                                                                  //
        }                                                                      //
    }
}
