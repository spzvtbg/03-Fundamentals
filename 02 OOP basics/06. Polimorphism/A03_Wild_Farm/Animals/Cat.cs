using System;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string SoundProduced => "Meow";

    public override double WeightGrowValue => 0.3;

    public override Type[] FoodEaten 
        => new Type[] 
        {
            typeof(Meat),
            typeof(Vegetable)
        };
}
