using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    public string type { get; set; }
    public List<Bender> Benders { get; }
    public List<Monument> Monuments { get; }

    public Nation()
    {
        this.Benders = new List<Bender>();
        this.Monuments = new List<Monument>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.type} Nation");
        if (Benders.Count == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");
            foreach (var bender in Benders)
            {
                sb.AppendLine($"###{bender}");
            }
        }
        if (Monuments.Count == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in Monuments)
            {
                sb.AppendLine($"###{monument}");
            }
        }
        return sb.ToString().Trim();
    }

    public double GetTotalNationPower()
    {
        var totalBendersPower = Benders.Sum(x => x.GetBenderPower());
        var bonusMonumentPower = Monuments.Sum(x => x.GetMonumentPower());
        if (bonusMonumentPower == 0)
        {
            bonusMonumentPower = 1;
        }
        var totalPower = totalBendersPower * bonusMonumentPower;
        return totalPower;
    }
}

