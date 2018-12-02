public class AvatarPoint
{
    public AvatarPoint(params string[] parameters)
    {
        this.Row = int.Parse(parameters[0]);
        this.Col = int.Parse(parameters[1]);
    }

    public int Row { get; set; }

    public int Col { get; set; }

    public void Next(int rowIndex, int colIndex)
    {
        this.Row += rowIndex;
        this.Col += colIndex;
    }
}
