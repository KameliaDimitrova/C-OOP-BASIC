using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    public Dictionary<string, Nation> nations;
    public StringBuilder issueWars;
    public int issueWarsCounter;
    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>();
        nations["Air"] = new Nation();
        nations["Water"] = new Nation();
        nations["Fire"] = new Nation();
        nations["Earth"] = new Nation();
        issueWars = new StringBuilder();
        issueWarsCounter = 1;
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secParam = double.Parse(benderArgs[3]);
        Bender bender = null;
        switch (type)
        {
            case "Air":
                bender = new AirBender(name, power, secParam);
                break;
            case "Water":
                bender = new WaterBender(name, power, secParam);
                break;
            case "Fire":
                bender = new FireBender(name, power, secParam);
                break;
            case "Earth":
                bender = new EarthBender(name, power, secParam);
                break;
            default: break;
        }
        nations[type].type = type;
        nations[type].Benders.Add(bender);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        Monument monument = null;
        switch (type)
        {
            case "Air":
                monument = new AirMonument(name, affinity);
                break;
            case "Water":
                monument = new WaterMonument(name, affinity);
                break;
            case "Fire":
                monument = new FireMonument(name, affinity);
                break;
            case "Earth":
                monument = new EarthMonument(name, affinity);
                break;
            default: break;
        }
        nations[type].type = type;
        nations[type].Monuments.Add(monument);
    }
    public string GetStatus(string nationsType)
    {
        var type = nationsType;
        return nations[type].ToString();
    }
    public void IssueWar(string nationsType)
    {
        issueWars.AppendLine($"War {issueWarsCounter} issued by {nationsType}");
        issueWarsCounter++;
        var totalPowerOfTheWinner = nations.Values.Max(x => x.GetTotalNationPower());
        foreach (var nation in nations)
        {
            if (nation.Value.GetTotalNationPower() < totalPowerOfTheWinner)
            {
                nation.Value.Benders.Clear();
                nation.Value.Monuments.Clear();
            }
        }
    }
    public string GetWarsRecord()
    {
        return this.issueWars.ToString().Trim();
    }

}

