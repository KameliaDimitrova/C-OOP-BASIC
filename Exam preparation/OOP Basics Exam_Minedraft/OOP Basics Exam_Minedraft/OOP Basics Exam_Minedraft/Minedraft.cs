public abstract class Minedraft
{
    private string id;

    public string Id
    {
        get { return id; }
      protected  set { id = value; }
    }

    protected Minedraft(string id)
    {
        this.Id = id;   
    }

}

