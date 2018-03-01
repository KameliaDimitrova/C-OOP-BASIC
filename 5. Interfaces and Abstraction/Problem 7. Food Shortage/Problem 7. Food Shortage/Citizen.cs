
class Citizen : People
{
    private string id;

    public string Id        
    {
        get { return id; }
        set { id = value; }
    }

    private string birthDate;

    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }
    public Citizen(string name, int age, string id,string birthDate)
        : base(name, age)
    {
        this.Id = id;
        this.BirthDate = birthDate;
    }

    public override void BuyFood()
    {
        this.Food = this.Food + 10;
    }
}
