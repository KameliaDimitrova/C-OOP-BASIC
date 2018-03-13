
using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Provider - {this.id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().Trim();
    }
}
