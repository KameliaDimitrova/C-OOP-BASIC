
public class LifeCreature
{
    private string name;

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    private string birthDate;

    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public LifeCreature(string name, string birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }


}

