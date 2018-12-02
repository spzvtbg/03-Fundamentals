using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private ICollection<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    public double Rating
    {
        get
        {
            if (this.players.Count == 0)
            {
                return 0;
            }

            return Math.Round(this.players.Sum(x => x.AvgStats) / this.players.Count);
        }
    }

    public void AddPlayer(string[] parameters)
    {
        this.players.Add(new Player(parameters.ToArray()));
    }

    public void RemovePlayer(string name)
    {
        if (!this.players.Any(x => x.Name == name))
        {
            throw new ArgumentException($"Player {name} is not in {this.Name} team.");
        }

        this.players.Remove(this.players.First(x => x.Name == name));
    }
}
