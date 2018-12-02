using System.Collections.Generic;

public class CustomCollection : IAddCollection, IAddRemoveCollection, IMyList
{
    private IList<string> collection;

    public CustomCollection()
    {
        this.collection = new List<string>();
    }

    int IAddCollection.Add(string item)
    {
        this.collection.Add(item);
        return this.collection.Count - 1;
    }

    int IAddRemoveCollection.Add(string item)
    {
        this.collection.Insert(0, item);
        return 0;
    }

    int IMyList.Add(string item)
    {
        this.collection.Insert(0, item);
        return 0;
    }

    string IAddRemoveCollection.Remove()
    {
        var element = this.collection[this.collection.Count - 1];
        this.collection.RemoveAt(this.collection.Count - 1);
        return element;
    }

    string IMyList.Remove()
    {
        var element = this.collection[0];
        this.collection.RemoveAt(0);
        return element;
    }

    public int Used()
    {
        return this.collection.Count;
    }
}
