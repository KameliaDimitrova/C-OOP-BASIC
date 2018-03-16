public class AirMonument : Monument
{
    private int airAffinity;

    public int AirAffinity 
    {
        get { return airAffinity; }
        private set { airAffinity = value; }
    }

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public override string ToString()
    {
        return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override double GetMonumentPower()
    {
        return this.AirAffinity / 100;
    }
}
