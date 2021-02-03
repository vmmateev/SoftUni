using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace _05_TeamWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < countTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();
                string user = input[0];
                string teamName = input[1];
                Team team = new Team();
                if (teams.Exists(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");     //•	If an user tries to create a team more than once, a message should be displayed: 
                    continue;
                }
                if (teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");       //•	A creator of a team cannot create another team – the following message should be thrown: 
                    continue;
                }
                team.TeamName = teamName;
                team.Creator = user;
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "end of assignment")
            {
                string[] membersJoin = inputCommand.Split("->");
                string memberName = membersJoin[0];
                string teamName = membersJoin[1];

                if (!teams.Any(x => x.TeamName == teamName))        //•	If an user tries to join a non-existent team, a message should be displayed: 
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.Members.Contains(memberName)) || (teams.Any(x => x.Creator == memberName && x.TeamName == teamName)))      //•	A member of a team cannot join another team – the following message should be thrown: защото е член на друг отбор или е създател на отбор
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                int index = teams.FindIndex(x => x.TeamName == teamName); // Намираме индекса на team-a към който искаме да добавим members
                teams[index].Members.Add(memberName); // Намираме обекта по индекс на който имаме съвпадение с име на отбор и добавяме към листа му members

            }
            // var disbanedTeams = new List<string>();
            //for (int i = 0; i < teams.Count; i++)
            //{
            //    if (teams.Any(x => x.Members.Count == 0))
            //    {
            //        string teamDisband = teams[i].TeamName;
            //        disbanedTeams.Add(teamDisband);
            //    }
            //}
            var disbanedTeams = teams.FindAll(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList(); // Създава лист в който намира всички обекти с лист който е с нула елемента и подреден по име на тийм

            foreach (var team in teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.ToString());
            }

            //var validTeams = teams.FindAll(x => x.Members.Count > 0).OrderBy(x => x.TeamName).ToList();                                                             //   Qvno e greshno tova i dolnoto i se zamestva ot gornoto^^
            //Console.WriteLine(string.Join(Environment.NewLine,validTeams.OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.TeamName)));

            Console.WriteLine("Teams to disband:");
            foreach (var disbandedTeam in disbanedTeams)
            {
                Console.WriteLine(disbandedTeam.TeamName);
            }

        }

        class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }

            public List<string> Members = new List<string>(); // Генерираме лист който да се създава празен автоматично за всеки нов обект и да се казва Members

            //public Team(string teamName, string creator/*, int members*/)
            //{
            //    TeamName = teamName;
            //    Creator = creator;
            //    //Members = members;
            //}

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(TeamName);
                sb.AppendLine("- " + Creator);
                Members.Sort();
                foreach (var member in Members/*.OrderBy(x => x)*/) // OrderBy e zamesteno ot SORT
                {
                    sb.AppendLine("-- " + member);
                }
                return sb.ToString().TrimEnd();

                // ili dolnoto ili gornoto 

                //string text = "";
                //text += TeamName + Environment.NewLine;
                //text += "- " + Creator + Environment.NewLine;
                //for (int i = 0; i < Members.Count; i++)
                //{
                //    if (i == Members.Count - 1)
                //    {
                //        text += "-- " + Members[i];
                //    }
                //    else
                //    {
                //    text += "-- " + Members[i] + Environment.NewLine;
                //    }
                //}

                //return text;
            }
        }
    }
}
