
class Citizen : LifeCreature
{
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private string birthDate;

 
    public Citizen(string name, int age, string id,string birthDate)
        :base(name,birthDate)
    {
        this.Age = age;
        this.Id = id;
    }
}

