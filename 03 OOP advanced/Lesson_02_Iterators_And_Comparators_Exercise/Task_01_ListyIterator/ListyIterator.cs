using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    private int index;
    private List<T> collection;

    public ListyIterator(params T[] collection)
    {
        this.collection = new List<T>(collection);
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            this.index++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        return this.index < this.collection.Count - 1;
    }

    public void Print()
    {
        if (this.collection.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.collection[this.index]);
    }
}
