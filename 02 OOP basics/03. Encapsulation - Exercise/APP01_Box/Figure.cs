using System;

public class Figure
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public void Print()
    {
        Console.WriteLine($"Surface Area - {(2 * this.Height * this.Width + 2 * this.Height * this.Length + 2 * this.Length * this.Width):F2}");
        Console.WriteLine($"Lateral Surface Area - {(2 * this.Length * this.Height + 2 * this.Width * this.Height):F2}");
        Console.WriteLine($"Volume - {(this.Length * this.Height * this.Width):F2}");
    }
}
