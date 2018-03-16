public abstract class Monument
{
    public string Name { get; }

    public Monument(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return "This is monuments";
    }

    public virtual double GetMonumentPower()
    {
        return 0d;
    }
}
