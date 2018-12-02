using System;

public class Mouse : Mamal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string SoundProduced => "Squeak";

    public override double WeightGrowValue => 0.1;

    public override Type[] FoodEaten
        => new Type[]
        {
            typeof(Fruit),
            typeof(Vegetable),
        };

    public override string ToString()
    {
        return string.Format(base.ToString(), string.Empty, $", {this.LivingRegion}");
    }
}
