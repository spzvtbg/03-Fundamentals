using System;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string SoundProduced => "Hoot Hoot";

    public override double WeightGrowValue => 0.25;

    public override Type[] FoodEaten
        => new Type[]
        {
            typeof(Meat),
        };
}
