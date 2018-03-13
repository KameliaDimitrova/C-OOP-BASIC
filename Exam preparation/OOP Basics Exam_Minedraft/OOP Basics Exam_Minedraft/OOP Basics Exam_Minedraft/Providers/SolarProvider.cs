
using System.Text;

public class SolarProvider:Provider
{
    public SolarProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        
    }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Solar ");
        return $"{sb.ToString()}{base.ToString()}";
    }
}

