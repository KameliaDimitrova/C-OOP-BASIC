
class Rebel : People
{
    private string group;

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public Rebel(string name, int age, string group)
        : base(name, age)
    {
        this.Group = group;
    }

    public override void BuyFood()
    {
       this.Food = this.Food + 5;
    }
}

