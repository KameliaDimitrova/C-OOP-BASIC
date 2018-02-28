
class Robot : IEnter
{
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string model;

    public string Model     
    {
        get { return model; }
        set { model = value; }
    }

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
}

