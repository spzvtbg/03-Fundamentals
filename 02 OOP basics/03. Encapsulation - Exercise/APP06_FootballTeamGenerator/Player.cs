using System;
using System.Linq;

public class Player
{
    private string name;
    private Stats stats;

    public Player(params string[] parameters)
    {
        this.Name = parameters[0];
        this.stats = new Stats(parameters.Skip(1).ToArray());
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

    public double AvgStats => this.stats.Sum;
}
