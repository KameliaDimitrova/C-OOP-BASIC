 public class FireBender:Bender
{
    private double heatAggression;

    public double HeatAggression
    {
        get { return heatAggression; }
        private set { heatAggression = value; }
    }

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }

    public override double GetBenderPower()
    {
        return this.Power * this.HeatAggression;
    }
}
