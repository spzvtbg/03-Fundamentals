using System;

public class Stats
{
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Stats(params string[] parameters)
    {
        this.Endurance = int.Parse(parameters[0]);
        this.Sprint = int.Parse(parameters[1]);
        this.Dribble = int.Parse(parameters[2]);
        this.Passing = int.Parse(parameters[3]);
        this.Shooting = int.Parse(parameters[4]);
    }

    private int Endurance
    {
        get
        {
            return this.endurance;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(this.Endurance)} should be between 0 and 100.");
            }

            this.endurance = value;
        }
    }

    private int Sprint
    {
        get
        {
            return this.sprint;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(this.Sprint)} should be between 0 and 100.");
            }

            this.sprint = value;
        }
    }

    private int Dribble
    {
        get
        {
            return this.dribble;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(this.Dribble)} should be between 0 and 100.");
            }

            this.dribble = value;
        }
    }

    private int Passing
    {
        get
        {
            return this.passing;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(this.Passing)} should be between 0 and 100.");
            }

            this.passing = value;
        }
    }

    private int Shooting
    {
        get
        {
            return this.shooting;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{nameof(this.Shooting)} should be between 0 and 100.");
            }

            this.shooting = value;
        }
    }

    public double Sum => (double)(this.Endurance + this.Sprint + this.Passing + this.Dribble + this.Shooting) / 5;
}
