using System;

public class Car
{
    public Car(params string[] parameters)
    {
        this.Parse(parameters);
    }

    public string Model { get; set; }

    public string EngineModel { get; set; }

    public Engine Engine { get; set; }

    public int? Weight { get; set; }

    public string Color { get; set; }

    public override string ToString()
    {
        return $"{this.Model}:{Environment.NewLine}" +
               $"  {this.EngineModel}:{Environment.NewLine}" +
               $"  {this.Engine.ToString()}{Environment.NewLine}" +
               $"  Weight: {this.Weight.Equal<int?>(null)}{Environment.NewLine}" +
               $"  Color: {this.Color.Equal<string>(null)}";
    }

    private void Parse(string[] parameters)
    {
        int length = parameters.Length;

        if (length >= 1)
        {
            this.Model = parameters[0];
        }

        if (length >= 2)
        {
            this.EngineModel = parameters[1];
        }

        if (length >= 3)
        {
            int weight = 0;

            if (int.TryParse(parameters[2], out weight))
            {
                this.Weight = weight;
            }
            else
            {
                this.Color = parameters[2];
            }
        }

        if (length == 4)
        {
            this.Weight = int.Parse(parameters[2]);
            this.Color = parameters[3];
        }
    }
}
