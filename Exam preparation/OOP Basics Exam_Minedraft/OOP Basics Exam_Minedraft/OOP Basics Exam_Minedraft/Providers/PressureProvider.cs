
using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput = this.EnergyOutput + 0.5 * this.EnergyOutput;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Pressure ");
        return $"{sb.ToString()}{base.ToString()}";
    }
}

