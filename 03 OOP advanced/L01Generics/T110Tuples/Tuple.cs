public class CustomTuple<T1, T2, T3>
{
    public CustomTuple() { }

    //public CustomTuple(TKey key, TValue value)
    //{
    //    this.Key = key;
    //    this.Value = value;
    //}

    public T1 Value1 { get; set; }

    public T2 Value2 { get; set; }

    public T3 Value3 { get; set; }

    public override string ToString()
    {
        return $"{this.Value1} -> {this.Value2} -> ";
    }
}
