using System;

public class Person : IComparable<Person>
{
    public Person(params string[] data)
    {
        this.Name = data[0];
        this.Town = data[2];
        this.Age = int.Parse(data[1]);
    }

    public string Name { get; }

    public int Age { get; }

    public string Town { get; }

    public int CompareTo(Person other)
    {
        var hasEqualName = this.Name == other.Name;
        var hasEqualAge = this.Age == other.Age;
        var hasEqualTown = this.Town == other.Town;

        if (hasEqualName && hasEqualAge && hasEqualTown)
        {
            return 0;
        }

        return -1;
    }
}
