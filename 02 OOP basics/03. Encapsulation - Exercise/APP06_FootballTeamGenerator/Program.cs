using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        ICollection<Team> teams = new List<Team>();

        var input = string.Empty;

        while ((input = Console.ReadLine()).ToUpper() != "END")
        {
            var data = input.SplitBy(";");

            if (data.Length < 2)
            {
                continue;
            }

            var command = data[0].ToLower();
            var teamName = data[1];

            try
            {
                if (command == "team")
                {
                    teams.Add(new Team(teamName));
                }
                else if (command == "add")
                {
                    var team = teams.FirstOrDefault(x => x.Name == teamName);

                    if (team == null)
                    {
                        throw new ArgumentException($"Team {teamName} dose not exist.");
                    }

                    team.AddPlayer(data.Skip(2).ToArray());
                }
                else if (command == "remove")
                {
                    var team = teams.FirstOrDefault(x => x.Name == teamName);

                    team.RemovePlayer(data[2]);
                }
                else if (command == "rating")
                {
                    var team = teams.FirstOrDefault(x => x.Name == teamName);

                    if (team == null)
                    {
                        throw new ArgumentException($"Team {teamName} dose not exist.");
                    }

                    Console.WriteLine($"{team.Name} - {team.Rating}");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
    }
}
