public class Car
{
    public Car(string model, string speed)
    {
        this.Model = model;
        this.Speed = int.Parse(speed);
    }

    public string Model { get; set; }

    public int Speed { get; set; }

    public override string ToString()
    {
        return $"{this.Model} {this.Speed}";
    }
}
