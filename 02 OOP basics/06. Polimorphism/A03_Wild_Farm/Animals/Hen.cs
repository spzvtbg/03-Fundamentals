using System;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string SoundProduced => "Cluck";

    public override double WeightGrowValue => 0.35;

    public override Type[] FoodEaten
        => new Type[]
        {
            typeof(Fruit),
            typeof(Meat),
            typeof(Seeds),
            typeof(Vegetable),
        };
}
