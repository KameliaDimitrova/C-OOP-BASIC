
using System;
using System.Collections.Generic;

public class Commando : SpecialisedSoldier
{
    private Dictionary<string,string> missions;

    public Dictionary<string,string> Missions
    {
        get { return missions; }
        set
        {
            missions = value;
        }
    }

    public Commando(int id, string firstName, string lastName, double salary, string corps,Dictionary<string, string> missions)
        : base(id, firstName, lastName,salary,corps)
    {
        this.Missions = missions;
    }

    public void CompleteMission(string codeName)
    {
        this.Missions[codeName] = "Finished";
    }
    public override string ToString()
    {
        var missionsResult = string.Empty;
        foreach (var mission in missions)
        {
            missionsResult = missionsResult + $"{Environment.NewLine}  Code Name: {mission.Key} State: {mission.Value}";
        }
        return $"{base.ToString()}{Environment.NewLine}" +
               $"Corps: {this.Corps}{Environment.NewLine}" +
               $"Missions:{missionsResult}";
    }
}

