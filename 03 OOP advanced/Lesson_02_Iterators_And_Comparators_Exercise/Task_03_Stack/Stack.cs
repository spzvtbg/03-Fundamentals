using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private Node<T> head;

    public int Count { get; private set; }

    public void Push(T element)
    {
        if (this.head == null)
        {
            this.head = new Node<T>(element);
        }
        else
        {
            var temporaryHead = this.head;
            this.head = new Node<T>(element, temporaryHead);
        }

        this.Count++;
    }

    public T Pop()
    {
        if (this.Count > 0)
        {
            var elementT = this.head.Element;
            this.head = this.head.Previous;
            this.Count--;
            return elementT;
        }

        throw new System.Exception("No elements");
    }

    public IEnumerator<T> GetEnumerator()
    {
        var collection = this.head;

        while (collection != null)
        {
            yield return collection.Element;
            collection = collection.Previous;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        var collection = this.head;

        while (collection.Previous != null)
        {
            yield return collection.Element;
            collection = collection.Previous;
        }
    }
}
