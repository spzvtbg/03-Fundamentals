using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
{
    const int INITIAL_CAPACITY = 4;

    private int count;
    private int capacity;
    private T[] collection;

    public CustomList()
    {
        this.capacity = INITIAL_CAPACITY;
        this.collection = new T[INITIAL_CAPACITY];
    }

    public IEnumerable<T> Content => new List<T>(this.collection.Take(this.count));

    public void Add(T element)
    {

        if (this.count >= INITIAL_CAPACITY)
        {
            this.Grow();
        }

        this.collection[this.count++] = element;
    }

    public T Remove(int index)
    {
        var element = this.collection[index];
        this.Shift(index);
        return element;
    }

    public bool Contains(T element)
    {
        foreach (var item in this.collection)
        {
            if (item == null)
            {
                break;
            }

            if (item.CompareTo(element) == 0)
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int index1, int index2)
    {
        var temporaryElement = this.collection[index1];
        this.collection[index1] = this.collection[index2];
        this.collection[index2] = temporaryElement;
    }

    public int CountGreaterThan(T element)
    {
        var countGreaterElements = 0;

        foreach (var item in this.collection)
        {
            if (item == null)
            {
                break;
            }

            if (item.CompareTo(element) > 0)
            {
                countGreaterElements++;
            }
        }

        return countGreaterElements;
    }

    public T Max()
    {
        var maxElement = default(T);

        foreach (var item in this.collection)
        {
            if (item == null)
            {
                break;
            }

            if (item.CompareTo(maxElement) > 0)
            {
                maxElement = item;
            }
        }

        return maxElement;
    }

    public T Min()
    {
        var minElement = this.collection[0];

        foreach (var item in this.collection)
        {
            if (item == null)
            {
                break;
            }

            if (item.CompareTo(minElement) < 0)
            {
                minElement = item;
            }
        }

        return minElement;
    }

    public void Sort()
    {
        Array.Sort(this.collection, 0, this.count);
    }

    private void Shift(int index)
    {
        for (int i = index; i < this.count - 1; i++)
        {
            this.collection[i] = this.collection[i + 1];
        }
        this.collection[this.count--] = default(T);
    }

    private void Grow()
    {
        var temporaryElements = new T[this.capacity *= 2];
        Array.Copy(this.collection, temporaryElements, this.count);
        this.collection = temporaryElements;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.collection.Take(this.count).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.collection.Take(this.count).GetEnumerator();
    }
}
