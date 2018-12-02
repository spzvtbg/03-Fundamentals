public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        var type = this.value.GetType().FullName;
        return $"{type}: {this.value}";
    }
}
