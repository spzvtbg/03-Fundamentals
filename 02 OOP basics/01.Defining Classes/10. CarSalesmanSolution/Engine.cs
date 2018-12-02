using System;

public class Engine
{
    public Engine() { }

    public Engine(params string[] parameters)
    {
        this.Parse(parameters);
    }

    public string Model { get; set; }

    public int? Power { get; set; }

    public int? Displacement { get; set; }

    public string Efficiency { get; set; }

    public override string ToString()
    {
        return $"  Power: {this.Power.Equal<int?>(null)}{Environment.NewLine}" +
               $"    Displacement: {this.Displacement.Equal<int?>(null)}{Environment.NewLine}" +
               $"    Efficiency: {this.Efficiency.Equal<string>(null)}";
    }

    private void Parse(string[] parameters)
    {
        var length = parameters.Length;

        if (length >= 1)
        {
            this.Model = parameters[0];
        }

        if (length >= 2)
        {
            this.Power = int.Parse(parameters[1]);
        }

        if (length >= 3)
        {
            int displacement;

            if (int.TryParse(parameters[2], out displacement))
            {
                this.Displacement = displacement;
            }
            else
            {
                this.Efficiency = parameters[2];
            }
        }

        if (length >= 4)
        {
            this.Efficiency = parameters[3];
        }
    }
}