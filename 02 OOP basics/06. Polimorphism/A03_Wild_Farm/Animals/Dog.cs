using System;

public class Dog : Mamal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override double WeightGrowValue => 0.4;

    public override string SoundProduced => "Woof!";

    public override Type[] FoodEaten
         => new Type[]
         {
            typeof(Meat)
         };

    public override string ToString()
    {
        return string.Format(base.ToString(), string.Empty, $", {this.LivingRegion}");
    }
}