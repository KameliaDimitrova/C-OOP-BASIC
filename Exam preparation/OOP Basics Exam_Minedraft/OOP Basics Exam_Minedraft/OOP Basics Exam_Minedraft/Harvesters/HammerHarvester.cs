
using System.Text;

public class HammerHarvester : Harvester
{
   
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = this.OreOutput + 2 * this.OreOutput;
        this.EnergyRequirement = this.EnergyRequirement + this.EnergyRequirement;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Hammer ");
        return $"{sb.ToString()}{base.ToString()}";
    }
}

