public abstract class Figure
{
    public Figure(params int[] parameters)
    {
        this.Parameters = parameters;
    }

    public int[] Parameters { get; set; }

    public virtual void Drow() { }
}