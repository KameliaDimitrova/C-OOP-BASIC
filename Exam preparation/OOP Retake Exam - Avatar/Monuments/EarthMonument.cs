public class EarthMonument : Monument
{
    private int earthAffinity;

    public int EarthAffinity
    {
        get { return earthAffinity; }
        private set { earthAffinity = value; }
    }

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }

    public override double GetMonumentPower()
    {
        return this.EarthAffinity / 100;
    }
}
