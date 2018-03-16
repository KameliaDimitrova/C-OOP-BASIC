public class AirBender : Bender
{
    private double aerialIntegrity;

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        private set { aerialIntegrity = value; }
    }

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }

    public override double GetBenderPower()
    {
        return this.Power * this.AerialIntegrity;
    }
}