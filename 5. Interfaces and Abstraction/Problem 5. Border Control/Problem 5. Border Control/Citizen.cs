
class Citizen:IEnter
{
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
}

