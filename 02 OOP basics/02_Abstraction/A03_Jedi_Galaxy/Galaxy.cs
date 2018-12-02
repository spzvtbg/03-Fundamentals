public class Galaxy
{
    private int x;
    private int y;
    private int count;

    private int[,] area;

    public Galaxy(params string[] parameters)
    {
        this.x = int.Parse(parameters[0]);
        this.y = int.Parse(parameters[1]);

        this.Initialize();
        this.Dimensions = new AvatarPoint(parameters[0], parameters[1]);
    }

    public AvatarPoint Dimensions { get; }

    private void Initialize()
    {
        this.area = new int[this.x, this.y];

        for (int x = 0; x < this.area.GetLength(0); x++)
        {
            for (int y = 0; y < this.area.GetLength(0); y++)
            {
                this.area[x, y] = this.count++;
            }
        }
    }

    public void SetAtPosition(int row, int col, int value)
    {
        try
        {
            this.area[row, col] = value;
        }
        catch
        {
            return;
        }
    }

    public long GetValue(int row, int col)
    {
        try
        {
            return this.area[row, col];
        }
        catch
        {
            return default(long);
        }
    }
}
