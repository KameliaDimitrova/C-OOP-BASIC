
public abstract class Bender
{
    public string Name { get; }
    public int Power { get; }

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public override string ToString()
    {
        return "It`s bender";
    }

    public virtual double GetBenderPower()
    {
        return 0d;
    }
}

