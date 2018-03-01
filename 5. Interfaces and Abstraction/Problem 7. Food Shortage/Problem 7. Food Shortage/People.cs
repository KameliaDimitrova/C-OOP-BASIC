
public abstract class People : IBuyer
{
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

    private int food;

    public int Food
    {
        get { return food; }
        set { food = value; }
    }

    public People(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Food = 0;
    }

    public virtual void BuyFood()
    {

    }
}

