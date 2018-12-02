public class Ferarri : ICar
{
    public Ferarri(string driver)
    {
        this.Driver = driver;
    }

    public string Driver { get; private set; }

    public string Model => "488-Spider";

    public string Break => "Brakes!";

    public string Gas => "Zadu6avam sA!";

    public override string ToString()
    {
        return $"{this.Model}/{this.Break}/{this.Gas}/{this.Driver}";
    }
}