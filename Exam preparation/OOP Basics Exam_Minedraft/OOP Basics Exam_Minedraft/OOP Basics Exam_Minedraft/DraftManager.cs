using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private string mode = "Full";
    private double totalStoredEnergy;
    private double totalMinedOre;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;


    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
    }

    
    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvesterType = arguments[0];
            var currId = arguments[1];
            var harvester = this.harvesterFactory.Get(arguments);
            harvesters[currId] = harvester;
            return $"Successfully registered {harvesterType} Harvester - {currId}";
        }
        catch (ArgumentException argEx)
        {
            return $"Harvester is not registered, because of it's {argEx.Message}";
        }

    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var providerType = arguments[0];
            var currId = arguments[1];
            var provider = this.providerFactory.Get(arguments);
            providers[currId] = provider;
            return $"Successfully registered {providerType} Provider - {currId}";
        }
        catch (ArgumentException argEx)
        {
            return $"Provider is not registered, because of it's {argEx.Message}";
        }
    }
    public string Day()
    {
        var sb = new StringBuilder();
        var dayOreMined = 0d;
        var neededEnergy = 0d;
        var dayEnergyProvided = providers.Sum(x => x.Value.EnergyOutput);
        this.totalStoredEnergy = this.totalStoredEnergy + dayEnergyProvided;
        switch (mode)
        {
            case "Full":
                dayOreMined = harvesters.Sum(x => x.Value.OreOutput);
                neededEnergy = harvesters.Sum(x => x.Value.EnergyRequirement);
                break;
            case "Half":
                dayOreMined = (harvesters.Sum(x => x.Value.OreOutput)) * 0.5;
                neededEnergy = (harvesters.Sum(x => x.Value.EnergyRequirement)) * 0.6;
                break;
            case "Energy":
                dayOreMined = 0;
                neededEnergy = 0;
                break;
            default: break;
        }
        if (totalStoredEnergy < neededEnergy)
        {
            sb.AppendLine($"A day has passed.");
            sb.AppendLine($"Energy Provided: {dayEnergyProvided}");
            sb.AppendLine($"Plumbus Ore Mined: 0");
        }
        else
        {
            sb.AppendLine($"A day has passed.");
            sb.AppendLine($"Energy Provided: {dayEnergyProvided}");
            sb.AppendLine($"Plumbus Ore Mined: {dayOreMined}");
            this.totalMinedOre = this.totalMinedOre + dayOreMined;
            this.totalStoredEnergy = this.totalStoredEnergy - neededEnergy;
        }
        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        var changeMode = arguments[0];
        this.mode = changeMode;
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var givenId = arguments[0];
        if (harvesters.ContainsKey(givenId))
        {
            return $"{harvesters[givenId]}";
        }
        if (providers.ContainsKey(givenId))
        {
            return $"{providers[givenId]}";
        }
        return $"No element found with id - {givenId}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");
        return sb.ToString().Trim();
    }

}

