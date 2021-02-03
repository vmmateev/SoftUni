using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                string personId = arguments[1];
                int age = int.Parse(arguments[2]);
                Person edinManqk = new Person(name, personId, age);
                people.Add(edinManqk);
            }

            people = people.OrderBy(x => x.Age).ToList(); // Order by връща IEnumerable което трябва дас е запише някаде за да се изведе на екрана 
            Console.WriteLine(string.Join(Environment.NewLine, people));
        }

        class Person
        {
            string Name { get; set; }
            string PersonID { get; set; }
            public int Age { get; set; }

            public Person(string name, string personId, int age)
            {
                this.Name = name;
                this.PersonID = personId;
                this.Age = age;
            }
            public override string ToString()
            {
                return $"{Name} with ID: {PersonID} is {Age} years old.";
            }
        }
    }
}
