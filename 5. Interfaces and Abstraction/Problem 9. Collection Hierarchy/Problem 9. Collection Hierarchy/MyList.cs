
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

public class MyList : IMyList
{
    private List<string> collection;

    public List<string> Collection
    {
        get { return collection; }
        set { collection = value; }
    }

    private int used;

    public int Used
    {
        get { return used; }
        set { used = value; }
    }

    public MyList()
    {
        this.collection = new List<string>();
    }

    public int Add(string item)
    {
        this.collection.Insert(0, item);
        this.Used = collection.Count;
        return 0;
    }

    public string Remove()
    {
        var removedElement = collection[0];
        this.collection.RemoveAt(0);
        return removedElement;
    }
}