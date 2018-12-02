using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
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

    public void PrintAll()
    {
        if (this.collection.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(string.Join(" ", this.collection));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int index = 0; index < this.collection.Count; index++)
        {
            yield return this.collection[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
