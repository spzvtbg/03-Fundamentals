public class Cargo
{
    public Cargo(string type, int weight)
    {
        this.CargoType = type;
        this.CargoWeight = weight;
    }

    public string CargoType { get; set; }

    public int CargoWeight { get; set; }
}