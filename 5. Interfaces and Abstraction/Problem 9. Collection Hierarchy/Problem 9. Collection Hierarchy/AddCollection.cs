
using System.Collections.Generic;

public class AddCollection:IAddCollection
{
    private List<string> collection;

    public List<string> Collection           
    {
        get { return collection; }
        set { collection = value; }
    }

    public AddCollection()
    {
        this.Collection=new List<string>();
    }
    public int Add(string item)
    {
        this.collection.Add(item);
        return collection.Count - 1;
    }
}

