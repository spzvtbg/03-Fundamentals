using System;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string SoundProduced => "ROAR!!!";

    public override double WeightGrowValue => 1;

    public override Type[] FoodEaten
        => new Type[]
        {
            typeof(Meat),
        };
}
