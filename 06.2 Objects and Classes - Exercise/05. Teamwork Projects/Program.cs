using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            InitializeTeam(teams);
            NewMethod(teams);
            PrintingTeamsWithMembers(teams);
            PrintteamsWithoutMembers(teams);
        }

        private static void PrintteamsWithoutMembers(List<Team> teams)
        {
            List<Team> teamsWithouthMembers = teams
                .Where(t => t.Members.Count == 0)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWithouthMembers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
            }
        }

        private static void PrintingTeamsWithMembers(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string memberName in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- { memberName}");
                }
            }
        }

        private static void NewMethod(List<Team> teams)
        {
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] cmdArgs = input.Split("->");
                string user = cmdArgs[0];
                string team = cmdArgs[1];
                if (!teams.Any(x => x.Name == team))
                { Console.WriteLine($"Team {team} does not exist!"); }
                else if (teams.Any(x => x.Creator == user) || teams.Any(x => x.Members.Contains(user)))
                { Console.WriteLine($"Member {user} cannot join team {team}!"); }
                else
                {
                    Team teamsToJoin = teams.First(t => t.Name == team);
                    teamsToJoin.AddMember(user);
                }
                input = Console.ReadLine();
            }
        }

        private static void InitializeTeam(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split('-');
                string creator = cmdArg[0];
                string teamName = cmdArg[1];
                if (teams.Any(x => x.Name == teamName))
                { Console.WriteLine($"Team {teamName} was already created!"); }
                else if (teams.Any(x => x.Creator == creator))
                { Console.WriteLine($"{creator} cannot create another team!"); }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }
    }
    public class Team
    {
        private readonly List<string> members;

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            this.members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> Members
            => members;
        public void AddMember(string membername)
        {
            this.members.Add(membername);
        }
    }
}
