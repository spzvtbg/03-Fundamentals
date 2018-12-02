public class Cat
{
    public Cat(params string[] parameters)
    {
        this.Name = parameters[1];
        this.Type = parameters[0];
        this.Parameter = double.Parse(parameters[2]);
    }

    public string Name { get; set; }

    public string Type { get; set; }

    public double Parameter { get; set; }

    public override string ToString()
    {
        var parameter = this.Type == "Cymric" ? $"{this.Parameter:F2}" : $"{this.Parameter}";
        return $"{this.Type} {this.Name} {parameter}";
    }
}
