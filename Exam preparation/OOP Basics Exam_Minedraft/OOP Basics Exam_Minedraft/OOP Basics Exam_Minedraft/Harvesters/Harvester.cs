
using System;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("OreOutput");
            }
            oreOutput = value;
        }
    }

    private double energyRequirement;

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0||value>20000)
            {
                throw new ArgumentException("EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Harvester - {this.id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString().Trim();
    }
}