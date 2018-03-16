public class WaterMonument : Monument
{
    private int waterAffinity;

    public int WaterAffinity
    {
        get { return waterAffinity; }
        private set { waterAffinity = value; }
    }

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public override string ToString()
    {
        return $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override double GetMonumentPower()
    {
        return this.WaterAffinity / 100;
    }
}
