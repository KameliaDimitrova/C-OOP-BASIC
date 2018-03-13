
using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;
    public SonicHarvester(string id, double oreOutput, double energyRequirement,int sonicFactor )
        : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / sonicFactor;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Sonic ");
        return $"{sb.ToString()}{base.ToString()}";
    }
}

