public class Bird : Animal
{
    protected Bird(string name, double weight, double wingSize) : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize { get; private set; }

    public override string ToString()
    {
        return string.Format(base.ToString(), $", {this.WingSize}", string.Empty);
    }
}
