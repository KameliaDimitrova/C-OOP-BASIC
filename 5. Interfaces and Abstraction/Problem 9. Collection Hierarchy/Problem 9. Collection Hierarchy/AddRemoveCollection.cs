
using System.Collections.Generic;

public class AddRemoveCollection:IAddRemoveCollection
{
    private List<string> collection;

    public List<string> Collection
    {
        get { return collection; }
        set { collection = value; }
    }

    public AddRemoveCollection()
    {
        this.Collection = new List<string>();
    }
    public int Add(string item)
    {
        this.collection.Insert(0, item);
        return 0;
    }

    public string Remove()
    {
        var removedElement = collection[collection.Count - 1];
        this.collection.RemoveAt(collection.Count-1);
        return removedElement;
    }
}

