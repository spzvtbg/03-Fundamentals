public class Pokemon
{
    public Pokemon(string name, string element, string health)
    {
        this.Name = name;
        this.Element = element;
        this.Health = int.Parse(health);
    }

    public string Name { get; set; }

    public string Element { get; set; }

    public int Health { get; set; }
}
