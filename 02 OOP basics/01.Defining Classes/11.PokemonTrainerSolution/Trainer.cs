using System.Collections.Generic;

public class Trainer
{
    public Trainer()
    {
        this.Pokemons = new List<Pokemon>();
    }

    public Trainer(string name) : this()
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public int Badges { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public void AddNew(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}
