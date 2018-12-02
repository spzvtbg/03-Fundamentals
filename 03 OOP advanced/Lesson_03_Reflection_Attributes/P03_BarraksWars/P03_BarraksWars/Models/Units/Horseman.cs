namespace P03_BarraksWars.Models.Units
{
    using _03BarracksFactory.Models.Units;

    public class Horseman : Unit
    {
        public Horseman() 
            : base(health: 50, attackDamage: 10)
        {
        }
    }
}
